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
        }

        

        private void Frm_ABM_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Nuevo_Cliente Frm_Alta_Cliente = new Frm_ABM_Nuevo_Cliente();
            Frm_Alta_Cliente.ShowDialog();
            Frm_Alta_Cliente.Dispose();
        }
    }
}
