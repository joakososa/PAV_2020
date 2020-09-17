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
    public partial class Frm_ABM_Mod_Cliente : Form
    {
        public Frm_ABM_Mod_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Mod_Cliente_Load(object sender, EventArgs e)
        {
            Btn_Nuevo.Enabled = false;
            Txt_CUIT.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Btn_Agregar.Enabled = false;
            Btn_Nuevo.Enabled = true;
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Txt_CUIT.Text = "";
            Txt_Descripcion.Text = "";
            Txt_Email.Text = "";
            Txt_RazonSocial.Text = "";
            Txt_Telefono.Text = "";
            Txt_CUIT.Focus();
            Btn_Nuevo.Enabled = false;
            Btn_Agregar.Enabled = true;
        }
    }
}
