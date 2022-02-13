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
    public partial class History : Form
    {
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        public History()
        {
            InitializeComponent();
        }
        public History(Account fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Account frm = new Account();

        private void History_Load(object sender, EventArgs e)
        {

            adpt = new SqlDataAdapter("select * from HistoryReservation where IdBeneficiar=" + frm.accountdefault.Id, connstring);
            dt = new DataTable();
            adpt.Fill(dt);

            dataGridViewReservations.DataSource = dt;

            dataGridViewReservations.Columns["Id"].Visible = false;
            dataGridViewReservations.Columns["IdBeneficiar"].Visible = false;

        }
    }
}
