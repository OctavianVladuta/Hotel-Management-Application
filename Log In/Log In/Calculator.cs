using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSQL_Accounts;

namespace Log_In
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public Calculator(Account fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Account frm = new Account();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var DBSQL = new DbSqlServerAccounts();
            DBSQL.UpdateAccountBalance(frm.accountdefault.Id, int.Parse(textBox.Text));
            frm.accountdefault = DBSQL.GetAccount(frm.accountdefault.Id);
            frm.AccountBalance.Text = $"{frm.accountdefault.AccountBalance}";
            MessageBox.Show("Account Balance was updated");
            this.Close();
        }
    }
}
