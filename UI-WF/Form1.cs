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

            int intHeight =  Int32.Parse(txtboxHeight.Text);
            int intWidth = Int32.Parse(txtboxWidth.Text);
            tblLayPanel.ColumnCount = intWidth;
            tblLayPanel.RowCount = intHeight;
            tblLayPanel.Refresh();

            for (int x = 0; x < intWidth; x++)
            {
                for (int y = 0; y < intHeight; y++)
                {
                    Button dynamicbutton = new Button();
                    dynamicbutton.Click += new System.EventHandler(Room_Click);
                    dynamicbutton.Text = "L";
                    dynamicbutton.Visible = true;
                    //dynamicbutton.Height = 25;
                    //dynamicbutton.Width = 30;
                    dynamicbutton.Font = new Font("Lucida Console", 4);
                    dynamicbutton.Parent = tblLayPanel;
                    tblLayPanel.SetColumn(dynamicbutton, x);
                    tblLayPanel.SetRow(dynamicbutton, y);
                    dynamicbutton.Anchor = AnchorStyles.Top;
                    dynamicbutton.Show();
                    //MessageBox.Show(tblLayPanel.Controls.Count.ToString());
                }
            }
            

        }

        private void Room_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
