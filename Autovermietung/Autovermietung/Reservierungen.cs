using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovermietung
{
    public partial class Reservierungen : Form
    {
        Reservieren reservieren = new Reservieren();
        public Reservierungen()
        {
            InitializeComponent();
        }

        private void Reservierungen_Load(object sender, EventArgs e)
        {
            reservieren.Anzeigen();  // soll die reservierten Autos anzeigen
        }

        
    }
}
