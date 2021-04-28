using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class VistaMarcas : Form
    {
        public VistaMarcas()
        {
            InitializeComponent();
        }

        private void VistaMarcas_Load(object sender, EventArgs e)
        {
            cargarGrillaMarcas();
        }

        private void cargarGrillaMarcas()
        {
            MarcaNegocio marcas = new MarcaNegocio();
            try
            {
                List<Marca> lista = marcas.listar();
                dGVMarcas.DataSource = lista;
                //dGVMarcas.Columns["Nombre"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
