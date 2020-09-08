using System;
using System.Windows.Forms;
using Ferreteria_Industrial.Formularios;

namespace Ferreteria_Industrial.Formularios
{
    public partial class Frm_Login : Form
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public Frm_Login()
        {
            InitializeComponent();
            Txt_Usuario.Focus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sesion_Click(object sender, EventArgs e)
        {
            if (Txt_Usuario.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario.","Campo requerido...",MessageBoxButtons.OK);
                Txt_Usuario.Focus();                
                return;
            }
            if (Txt_Password.Text == "")
            {
                MessageBox.Show("Ingrese el password.","Campo reuerido...", MessageBoxButtons.OK);
                Txt_Password.Focus();
                return;
            }
            this.Usuario = Txt_Usuario.Text;
            this.Close();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
