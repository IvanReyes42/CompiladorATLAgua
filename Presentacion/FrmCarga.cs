using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCarga : Form
    {
        public FrmCarga()
        {
            InitializeComponent();
        }

        private void FrmCarga_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();

            this.Hide();
            timer1.Enabled = false;
        }
    }
}
