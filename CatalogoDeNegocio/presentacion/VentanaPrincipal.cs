using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void ListarMarcas_Click(object sender, EventArgs e)
        {
            VistaMarcas nuevo = new VistaMarcas();
            nuevo.ShowDialog();
        }
    }
}
