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
    public partial class FrmMensaje : Form
    {
        public FrmMensaje(string Titulo, string Mensaje, int numero)
        {
            InitializeComponent();
            lblMensaje.Text = Mensaje;
            LblTitulo.Text = Titulo;
            PbIcono.Image = Image.FromFile("Imagen " + numero + ".png");
            PbIcono.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FrmMensaje_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
