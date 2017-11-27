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
        private DbManager dbManager;

        public RocketForm()
        {
            InitializeComponent();
            mainForm = this;
            dbManager = new DbManager();
            registerForm = new RegisterForm(dbManager);
        }

        private void rocketForm_Load(object sender, EventArgs e)
        {
            
        }

        private void rocketTitlePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Red),
                new Rectangle(rocketTitlePanel.Width / 4, rocketTitlePanel.Height / 16,
                    rocketTitlePanel.Width / 16, 3 * rocketTitlePanel.Height / 2));
            Point[] p = new Point[3];
            p[0] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 16 - 1, 
                rocketTitlePanel.Height / 16 + 11);
            p[1] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 16,
                rocketTitlePanel.Height / 16 + rocketTitlePanel.Height / 2 + 10);
            p[2] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 4,
                rocketTitlePanel.Height / 16 + rocketTitlePanel.Height / 4 + 10);
            e.Graphics.DrawClosedCurve(new Pen(new SolidBrush(Color.Red), 20), p);
            Point[] p1 = new Point[5];
            p1[0] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 16 - 1,
                rocketTitlePanel.Height / 2);
            p1[1] = new Point(rocketTitlePanel.Width / 4, 
                rocketTitlePanel.Height / 2 + rocketTitlePanel.Height / 16);
            p1[2] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 4,
                3 * rocketTitlePanel.Height / 2);
            p1[3] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 4,
                rocketTitlePanel.Height / 16 + 3 * rocketTitlePanel.Height / 4);
            p1[4] = new Point(rocketTitlePanel.Width / 4 + rocketTitlePanel.Width / 8,
                rocketTitlePanel.Height / 16 + 3 * rocketTitlePanel.Height / 4);
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), p1);
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
