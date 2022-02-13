using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DSQL_Rooms;
using DSQL_Users;

namespace Log_In
{
    public partial class AccountsAdminInterface : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public static SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        internal DataSet dsXML;
        DataSet ds;
        public AccountsAdminInterface()
        {
            InitializeComponent();
        }
        public AccountsAdminInterface(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Form1 frm = new Form1();

        private void AccountsAdminInterface_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select A.Id,A.Email,B.Nume,B.Prenume,B.Email,B.Telefon,B.Adresa,B.Oras,B.Tara,B.Cod_postal,B.AccountBalance from Users as A inner join Accounts as B on A.Id=B.Id", connstring);
            dt = new DataTable();

            adpt.Fill(dt);
            // adpt.Fill(ds);
            dataGridViewUsers.DataSource = dt;
            dataGridViewUsers.AutoResizeColumns();
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var DBSQL = new DbSqlServerRooms();
            int id = int.Parse(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value.ToString());
            int tipCamera = DBSQL.TypeCamera(id);
            string NumberRoom = DBSQL.NumberRoom(id);
            using (con = new SqlConnection(connstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Users where Id='" + id + "'", con);
                SqlCommand cmd1 = new SqlCommand("delete from Accounts where Id='" + id + "'", con);
                SqlCommand cmd2 = new SqlCommand("delete from HistoryReservation where IdBeneficiar = '" + id + "'", con);
                SqlCommand cmd3 = new SqlCommand("update Rooms set NrCamere = NrCamere + 1 where TipCamera = '" + tipCamera + "'", con);
                SqlCommand cmd4 = new SqlCommand("update TotalRooms set Disponibility = 'Empty' where RoomNumber = '" + NumberRoom + "'", con);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();

            }
            con.Close();
            int rowindex = dataGridViewUsers.CurrentCell.RowIndex;

            frm.userslist.usersList.Clear();
            foreach (var users in new DbSqlServerUsers().GetAll())
            {
                frm.userslist.usersList.Add(users);
            }
            dataGridViewUsers.Rows.RemoveAt(rowindex);
            MessageBox.Show("Ștergere efectuată");
        }

        private void exportXMLButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            ds = new DataSet();
            adpt.Fill(ds);
            save.Filter = "XML|*.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                ds.Tables[0].WriteXml(save.FileName);
            }
        }

        private void importXMLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML|*.xml";
            dsXML = new DataSet();
            if (open.ShowDialog() == DialogResult.OK)
            {
                dsXML.ReadXml(open.FileName);
            }

            XMLImport form = new XMLImport(this);
            form.Show();
        }
    }
}
