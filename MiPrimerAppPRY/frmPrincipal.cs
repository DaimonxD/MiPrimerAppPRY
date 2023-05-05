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
    public partial class frmCalculoDelMes : Form
    {
        public frmCalculoDelMes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAlacena ventanaAlamerienda = new frmAlacena();

            ventanaAlamerienda.ShowDialog();


        }
    }
}
