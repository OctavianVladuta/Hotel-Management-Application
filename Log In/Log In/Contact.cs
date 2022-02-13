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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        public Contact(Interface fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Interface frm = new Interface();
    }
}
