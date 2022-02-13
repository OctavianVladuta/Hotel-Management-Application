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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        public Rooms(Interface fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Interface frm = new Interface();

        private void viewRoomButton1_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Room1 room = new Room1();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(room);
            room.Show();
        }
    }
}
