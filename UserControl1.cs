using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class homescreen_card : UserControl
    {
        public homescreen_card()
        {
            InitializeComponent();
            Rectangle r = new Rectangle(0, 0, userPictureBox.Width, userPictureBox.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            userPictureBox.Region = new Region(gp);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.tableLayoutPanel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }



        private void tableLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void homescreen_card_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.HighlightText;
        }

        private void homescreen_card_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
