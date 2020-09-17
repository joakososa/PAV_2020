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
    public partial class Frm_ABM_Clientes : Form
    {
        public Frm_ABM_Clientes()
        {
            InitializeComponent();           
            Txt_CUIT.Focus();
        }

        private void Frm_ABM_Clientes_Load(object sender, EventArgs e)
        {
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Nuevo_Cliente Nuevo_Cliente = new Frm_ABM_Nuevo_Cliente();
            Nuevo_Cliente.ShowDialog();
            Nuevo_Cliente.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_ABM_Mod_Cliente Mod_Cliente = new Frm_ABM_Mod_Cliente();
            Mod_Cliente.ShowDialog();
            Mod_Cliente.Dispose();
            Btn_Modificar.Enabled = false;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
           MessageBox.Show("¿Está seguro de eliminar el Cliente?", "El Cliente seleccionado se va a eliminar de la Base de Datos",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            Btn_Eliminar.Enabled = false;
        }
    }
}
