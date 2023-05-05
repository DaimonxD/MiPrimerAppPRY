using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAppPRY
{
    public partial class frmAlacena : Form
    {
        public frmAlacena()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            optAlacena.Checked = false;
            optBaño.Checked = false;
            optHeladera.Checked = false;
            cboProducto.Text = "Ingrese Producto";
            nudCantidad.Value = 0;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
