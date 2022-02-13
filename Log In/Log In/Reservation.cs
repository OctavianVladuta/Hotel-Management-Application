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
using DBSQL_Reservation;
using DSQL_Accounts;
using DSQL_Rooms;
using StoredProcedure;

namespace Log_In
{
    public partial class Reservation : Form
    {
        internal ReservationHistoryList listaRezervari = new ReservationHistoryList();
        Accounts accountdefault = new Accounts();
        Procedure ps = new Procedure();
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        SqlDataAdapter adpt;
        DataTable dt;
        int x;

        public Reservation()
        {
            InitializeComponent();
        }

        public Reservation(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Form1 frm = new Form1();

        private void Reservation_Load(object sender, EventArgs e)
        {

            listaRezervari.reservationList.Clear();

            var DBSQL = new DbSqlServerAccounts();
            accountdefault = DBSQL.GetAccount(frm.userdefault.Id);
            foreach (var rezervare in new DbSqlServerReservation().GetReservation())
            {
                listaRezervari.reservationList.Add(rezervare);
            }
            metroComboBox1.Items.Add("Cameră dublă cu balcon (1)");
            metroComboBox1.Items.Add("Cameră dublă fără balcon (2)");
            metroComboBox1.Items.Add("Cameră dublă superioară (3)");
            metroComboBox1.Items.Add("Cameră Family (4)");


            if (accountdefault.Picture != "")
                profilePictureBox.ImageLocation = accountdefault.Picture;
            else
                profilePictureBox.ImageLocation = "C:\\Users\\Octavian\\Desktop\\Poze proprietati\\account_50px.png";
            AccountBalance.Text = accountdefault.AccountBalance.ToString();

            bunifuDatepickerCome.Value = DateTime.Today;
            bunifuDatepickerLeft.Value = DateTime.Today.AddDays(1);

            TotalPlatalabel.Visible = false;
            totalPlată.Visible = false;
            DateAvertisement.Visible = false;
            labelLei.Visible = false;
            TypeCameraAdvertisement.Visible = false;


            adpt = new SqlDataAdapter("select * from TotalRooms", connstring);
            dt = new DataTable();
            adpt.Fill(dt);

            dataGridViewRooms.DataSource = dt;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeCameraAdvertisement.Visible = false;
            string select = "select * from TotalRooms";
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(select, con);
            DataSet ds = new DataSet();
            adpt = new SqlDataAdapter(select, con);
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            adpt.Fill(ds, "Camere");
            DataView dv = new DataView(ds.Tables["Camere"]);



            //totalPlată.Text = ps.totalPlata(bunifuDatepickerCome.Value, bunifuDatepickerLeft.Value, 45).ToString();
            string d1 = bunifuDatepickerCome.Value.ToString("yyyy-MM-dd");
            string d2 = bunifuDatepickerLeft.Value.ToString("yyyy-MM-dd");

            x = ps.tarif(metroComboBox1.SelectedIndex + 1);
            if (bunifuDatepickerCome.Value < bunifuDatepickerLeft.Value)
            {
                totalPlată.Text = ps.totalPlata(d1, d2, x).ToString();
                TotalPlatalabel.Visible = true;
                totalPlată.Visible = true;
                labelLei.Visible = true;
            }

            dv.RowFilter = "TypeRoom='" + (metroComboBox1.SelectedIndex + 1) + "' and Disponibility='Empty'";
            //adpt = new SqlDataAdapter("select * from TotalRooms where TypeRoom='"+(metroComboBox1.SelectedIndex+1)+"'", connstring);
            // dt = new DataTable();
            // adpt.Fill(dt);

            dataGridViewRooms.DataSource = dv;

        }

        private void bunifuDatepickerCome_onValueChanged(object sender, EventArgs e)
        {
            DateAvertisement.Visible = false;
            if (metroComboBox1.SelectedItem != null)
                x = ps.tarif(metroComboBox1.SelectedIndex + 1);
            string d1 = bunifuDatepickerCome.Value.ToString("yyyy-MM-dd");
            string d2 = bunifuDatepickerLeft.Value.ToString("yyyy-MM-dd");
            if (bunifuDatepickerCome.Value >= bunifuDatepickerLeft.Value || bunifuDatepickerCome.Value < DateTime.Today)
            {
                DateAvertisement.Visible = true;
                TotalPlatalabel.Visible = false;
                totalPlată.Visible = false;
                labelLei.Visible = false;
            }
            else
            {
                totalPlată.Text = ps.totalPlata(d1, d2, x).ToString();
                TotalPlatalabel.Visible = true;
                totalPlată.Visible = true;
                labelLei.Visible = true;
            }

        }

        private void bunifuDatepickerLeft_onValueChanged(object sender, EventArgs e)
        {
            DateAvertisement.Visible = false;
            if (metroComboBox1.SelectedItem != null)
                x = ps.tarif(metroComboBox1.SelectedIndex + 1);
            string d1 = bunifuDatepickerCome.Value.ToString("yyyy-MM-dd");
            string d2 = bunifuDatepickerLeft.Value.ToString("yyyy-MM-dd");

            if (bunifuDatepickerCome.Value >= bunifuDatepickerLeft.Value || bunifuDatepickerCome.Value < DateTime.Today)
            {
                DateAvertisement.Visible = true;
                TotalPlatalabel.Visible = false;
                totalPlată.Visible = false;
                labelLei.Visible = false;
            }
            else
            {
                totalPlată.Text = ps.totalPlata(d1, d2, x).ToString();
                TotalPlatalabel.Visible = true;
                totalPlată.Visible = true;
                labelLei.Visible = true;
            }
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            string d1 = bunifuDatepickerCome.Value.ToString("yyyy-MM-dd");
            string d2 = bunifuDatepickerLeft.Value.ToString("yyyy-MM-dd");
            var DBSQL = new DbSqlServerAccounts();
            var DBSQL1 = new DbSqlServerRooms();
            var DBSQL2 = new DbSqlServerReservation();
            var NumberRoom = dataGridViewRooms.SelectedRows[0].Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            if (DateAvertisement.Visible == true)
                return;
            if (metroComboBox1.Text == "")
            {
                TypeCameraAdvertisement.Visible = true;
                return;
            }
            x = ps.tarif(metroComboBox1.SelectedIndex + 1);




            if (accountdefault.AccountBalance - int.Parse(ps.totalPlata(d1, d2, x)) < 0)
            {
                MessageBox.Show("Tranzactia nu se poate efectua. Fonduri insuficiente");
                return;
            }
            else
            {
                DBSQL.UpdateAccountBalanceMinus(frm.userdefault.Id, int.Parse(ps.totalPlata(d1, d2, x)));
                accountdefault = DBSQL.GetAccount(frm.userdefault.Id);
                AccountBalance.Text = accountdefault.AccountBalance.ToString();
                DBSQL1.setRoomsNumber(metroComboBox1.SelectedIndex + 1);
                DBSQL1.setRoomsDisponibility(NumberRoom);

                ReservationHistory rezervare = new ReservationHistory();
                rezervare.Id = id();
                rezervare.dataSosire = bunifuDatepickerCome.Value;
                rezervare.dataPlecare = bunifuDatepickerLeft.Value;
                rezervare.NoRoom = NumberRoom;
                rezervare.TypeRoom = metroComboBox1.SelectedIndex + 1;
                rezervare.totalPlata = int.Parse(ps.totalPlata(d1, d2, x));

                DBSQL2.Create(rezervare.Id, bunifuDatepickerCome.Value, bunifuDatepickerLeft.Value, NumberRoom, metroComboBox1.SelectedIndex + 1, int.Parse(ps.totalPlata(d1, d2, x)), accountdefault.Id);
                listaRezervari.reservationList.Add(rezervare);
                string select = "select * from TotalRooms";

                SqlCommand cmd = new SqlCommand(select, con);
                DataSet ds = new DataSet();
                adpt = new SqlDataAdapter(select, con);
                adpt.SelectCommand = cmd;
                adpt.Fill(dt);
                adpt.Fill(ds, "Camere");
                DataView dv = new DataView(ds.Tables["Camere"]);
                dv.RowFilter = "TypeRoom='" + (metroComboBox1.SelectedIndex + 1) + "' and Disponibility='Empty'";
                dataGridViewRooms.DataSource = dv;

            }

            MessageBox.Show("Rezervarea a fost făcută cu succes");
            con.Close();

        }

        public int id()
        {
            int i = 1;
            foreach (var rezervare in listaRezervari.reservationList)
            {
                if (i != rezervare.Id)
                    return i;
                i++;
            }
            return listaRezervari.reservationList.Count + 1;
        }
    }
}
