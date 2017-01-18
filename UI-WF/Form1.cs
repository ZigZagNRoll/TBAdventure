using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateWorld_Click(object sender, EventArgs e)
        {
            Button dynamicbutton = new Button();
            dynamicbutton.Click += new System.EventHandler(Room_Click);
            dynamicbutton.Text = "Een kamer";
            dynamicbutton.Visible = true;
            dynamicbutton.Height = 25;
            dynamicbutton.Width = 30;
            dynamicbutton.Font = new Font("Lucida Console", 16);
            dynamicbutton.Show();
            dynamicbutton.Parent = panel1;
            MessageBox.Show(panel1.Controls.Count.ToString());

        }

        private void Room_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
