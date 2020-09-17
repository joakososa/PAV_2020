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
    public partial class Frm_ABM_Proveedor : Form
    {
        public Frm_ABM_Proveedor()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_ABM_Nuevo_Proveedores Nuevo_Proveedor = new Frm_ABM_Nuevo_Proveedores();
            Nuevo_Proveedor.ShowDialog();
            Nuevo_Proveedor.Dispose();
        }

        private void Frm_ABM_Proveedor_Load(object sender, EventArgs e)
        {
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Nuevo_Proveedores Nuevo_Proveedor = new Frm_ABM_Nuevo_Proveedores();
            Nuevo_Proveedor.ShowDialog();
            Nuevo_Proveedor.Dispose();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_ABM_Mod_Proveedor Mod_Proveedor = new Frm_ABM_Mod_Proveedor();
            Mod_Proveedor.ShowDialog();
            Mod_Proveedor.Dispose();
            Btn_Modificar.Enabled = false;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro de eliminar el Proveedor?", "El Proveedor seleccionado se va a eliminar de la Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Btn_Eliminar.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }
    }
}
