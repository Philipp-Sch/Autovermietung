using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autovermietung.Properties;

namespace Autovermietung
{
    public partial class RocketForm : Form
    {
        private Graphics g;
        private RegisterForm registerForm;
        private RocketForm mainForm;

        public RocketForm()
        {
            InitializeComponent();
            mainForm = this;
            registerForm = new RegisterForm();
            registerForm.FormClosed += registerFormFormClosed;
        }

        void registerFormFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void rocketFormLoad(object sender, EventArgs e)
        {
            
        }

        private void rocketTitlePanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Red),
                new Rectangle(rocketTitlePanel.Width / 4, rocketTitlePanel.Height / 16,
                    rocketTitlePanel.Width / 16, 3 * rocketTitlePanel.Height / 2));
            Point[] points = new Point[3];
            points[0] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 16 - 1, 
                rocketTitlePanel.Height / 16 + 11);
            points[1] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 16,
                rocketTitlePanel.Height / 16 + rocketTitlePanel.Height / 2 + 10);
            points[2] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 4,
                rocketTitlePanel.Height / 16 + rocketTitlePanel.Height / 4 + 10);
            e.Graphics.DrawClosedCurve(new Pen(new SolidBrush(Color.Red), 20), points);
            points = new Point[5];
            points[0] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 16 - 1,
                rocketTitlePanel.Height / 2);
            points[1] = new Point(rocketTitlePanel.Width / 4, 
                rocketTitlePanel.Height / 2 + rocketTitlePanel.Height / 16);
            points[2] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 4,
                3 * rocketTitlePanel.Height / 2);
            points[3] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 4,
                rocketTitlePanel.Height / 16 + 3 * rocketTitlePanel.Height / 4);
            points[4] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 8,
                rocketTitlePanel.Height / 16 + 3 * rocketTitlePanel.Height / 4);
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            mainForm.Hide();
            registerForm.Show();
        }
    }
}
