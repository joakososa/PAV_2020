using System;
using System.Windows.Forms;
using Ferreteria_Industrial.Formularios;
using Ferreteria_Industrial.Negocio;

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
                MessageBox.Show("Ingrese el password.","Campo requerido...", MessageBoxButtons.OK);
                Txt_Password.Focus();
                return;
            }
            NG_Users Usuario = new NG_Users();
            if (Usuario.Validar_Usuario (Txt_Usuario.Text,Txt_Password.Text)== NG_Users.Respuesta.Validacion_Correcta)
             {
                this.Usuario = Txt_Usuario.Text;
                this.Close();
             }  
            else
            {
                MessageBox.Show("Este usuario no existe en la Base de Datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
            
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Usuario = "";
            this.Close();

        }
    }
}
