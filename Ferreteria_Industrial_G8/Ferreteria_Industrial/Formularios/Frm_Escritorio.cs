using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_Industrial.Formularios;

namespace Ferreteria_Industrial
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            Frm_Login Login = new Frm_Login();
            Login.ShowDialog();
            Lbl_Sesion.Text = "Sesión: " + Login.Usuario;
            Login.Dispose();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ABM_Clientes Frm_clientes = new Frm_ABM_Clientes();
            Frm_clientes.ShowDialog();
            Frm_clientes.Dispose();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Proveedores Frm_prov = new Frm_ABM_Proveedores();
            Frm_prov.ShowDialog();
            Frm_prov.Dispose();
        }
    }
}
