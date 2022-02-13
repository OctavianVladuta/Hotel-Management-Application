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

namespace Log_In
{
    public partial class ReservesAdminInterface : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public static SqlConnection con;
        DataTable dt = new DataTable();
        SqlDataAdapter adpt;

        SqlTransaction transaction;
        public ReservesAdminInterface()
        {
            InitializeComponent();
        }
        public ReservesAdminInterface(AdminInterface fr)
        {
            InitializeComponent();
            frm = fr;
        }
        AdminInterface frm = new AdminInterface();

        private void ReservesAdminInterface_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select * from HistoryReservation", connstring);
            dt = new DataTable();
            adpt.Fill(dt);

            dataGridViewReserves.DataSource = dt;
            dataGridViewReserves.Columns["Id"].Visible = false;
            dataGridViewReserves.Columns["IdBeneficiar"].Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(connstring))
            {
                try
                {
                    var NumberRoom = dataGridViewReserves.SelectedRows[0].Cells[3].Value.ToString();
                    var TypeRoom = dataGridViewReserves.SelectedRows[0].Cells[4].Value.ToString();
                    var Id = dataGridViewReserves.SelectedRows[0].Cells[0].Value.ToString();
                    int rowindex = dataGridViewReserves.CurrentCell.RowIndex;
                    con.Open();
                    transaction = con.BeginTransaction();
                    SqlCommand cmd = new SqlCommand("update Rooms set NrCamere = NrCamere + 1 where TipCamera = '" + int.Parse(TypeRoom) + "'", con, transaction);
                    SqlCommand cmd1 = new SqlCommand("update TotalRooms set Disponibility = 'Empty' where RoomNumber = '" + NumberRoom + "'", con, transaction);
                    SqlCommand cmd2 = new SqlCommand("delete from HistoryReservation where IdBeneficiar = '" + Id + "'", con, transaction);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        dataGridViewReserves.Rows.RemoveAt(rowindex);
                        MessageBox.Show("Stergere efectuata");
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Stergerea a esuat" + ex);
                        transaction.Rollback();
                    }

                    finally
                    {
                        con.Close();
                    }
                }
                catch
                {
                    if (dataGridViewReserves.Rows.Count == 0)
                        MessageBox.Show("Nu există rezervări");

                    else
                        MessageBox.Show("Selectati o rezervare din tabel");
                }
            }
        }
    }
}

