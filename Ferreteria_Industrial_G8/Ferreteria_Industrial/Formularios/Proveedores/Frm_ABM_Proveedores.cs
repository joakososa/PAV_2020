using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_Industrial.Formularios
{
    public partial class Frm_ABM_Proveedores : Form
    {
        public Frm_ABM_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Nuevo_Proveedores Frm_Alta_Prov = new Frm_ABM_Nuevo_Proveedores();
            Frm_Alta_Prov.ShowDialog();
            Frm_Alta_Prov.Dispose();
        }
    }
}
