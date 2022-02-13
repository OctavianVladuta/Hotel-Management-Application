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
    public partial class XMLImport : Form
    {
        public XMLImport()
        {
            InitializeComponent();
        }
        public XMLImport(AccountsAdminInterface fr)
        {
            InitializeComponent();
            frm = fr;
        }
        AccountsAdminInterface frm = new AccountsAdminInterface();

        private void XMLImport_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = frm.dsXML.Tables[0].DefaultView;
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
