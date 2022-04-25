using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.cache;
using domain;
using System.Runtime.InteropServices;


namespace Presentation
{
    public partial class Register_Form : Form
    {
        UserModel objetoCo = new UserModel();
        public Register_Form()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Register_Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_register_Click(object sender, EventArgs e)
        {
            loginform mainMenu = new loginform();
            mainMenu.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtEmail.Text != "" && txtPosition.Text != "" && txtTelefono.Text != "")
            {
                if(txtContraseña.Text == TxtConfirmpass.Text)
                {
                    objetoCo.InsertarUsuario(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtPosition.Text, txtEmail.Text,  Convert.ToInt32(txtTelefono.Text));
                    MessageBox.Show("Se ha registrado Correctamente");

                    loginform loginmain = new loginform();
                    loginmain.Show();
                  
                    this.Hide();
                    
                    
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden , vuelva a intentarlo");

            }
            else
                MessageBox.Show("Favor de llenar todos los campos");
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
