using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        public AdminInterface(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Form1 frm = new Form1();

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }

        private void reservesButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            ReservesAdminInterface frm1 = new ReservesAdminInterface(this);
            frm1.TopLevel = false;
            frm1.Dock = DockStyle.Fill;
            frm1.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frm1);
            frm1.Show();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            panel_main.Controls.Add(panel2);
            panel_main.Controls.Add(panel_cover);
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            AccountsAdminInterface frm1 = new AccountsAdminInterface(frm);
            frm1.TopLevel = false;
            frm1.Dock = DockStyle.Fill;
            frm1.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frm1);
            frm1.Show();
        }
    }
}
