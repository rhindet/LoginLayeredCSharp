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

namespace Presentation
{
    public partial class User_Mode : Form
    {
        public User_Mode()
        {
            InitializeComponent();
        }

        private void User_Mode_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControl();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadUserData()
        {
            lbl_user_edit.Text = UserLoginCache.LoginName;
            lbl_name_edit.Text = UserLoginCache.FirstName;
            lbl_lastName_edit.Text = UserLoginCache.LastName;   
            lbl_email_edit.Text= UserLoginCache.Email;
            lbl_position_edit.Text = UserLoginCache.Position;
            lbl_telefono_edit.Text = UserLoginCache.telefono.ToString();

            txt_usuario_edit.Text = UserLoginCache.LoginName;
            txt_Nombre_edit.Text = UserLoginCache.FirstName;
            txt_Apellido_edit.Text = UserLoginCache.LastName;
            txt_Email_edit.Text = UserLoginCache.Email;
            txt_position_edit.Text = UserLoginCache.Position;
            txt_Telefono_edit.Text = UserLoginCache.telefono.ToString();
            txt_confirmpass_edit.Text = UserLoginCache.Password;
            txt_Password_edit.Text = UserLoginCache.Password;
            txt_currentpass_edit.Text = "";
        }
        private void initializePassEditControl()
        {
            txt_confirmpass_edit.Enabled = false;
            txt_position_edit.Enabled = false;
            linkEditPass.Text = "Edit";
            txt_Password_edit.Enabled = false;
            txt_Password_edit.UseSystemPasswordChar = true;
            txt_Password_edit.Enabled = false;
            txt_currentpass_edit.Enabled = true;
            txt_confirmpass_edit.UseSystemPasswordChar=true;
        }

        private void reset()
        {
            loadUserData();
            initializePassEditControl();
           
        }

        private void LinkEditEdicion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
        }

        private void linkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditPass.Text == "Edit")
            {
                linkEditPass.Text = "Cancel";
                txt_Password_edit.Enabled=true;
                txt_Password_edit.Text = "";
                txt_confirmpass_edit.Enabled = true;
                txt_confirmpass_edit.Text="";


            }
            else if(linkEditPass.Text == "Cancel")
            {
                reset();
            }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txt_Password_edit.Text.Length >= 5)
            {
                if (txt_Password_edit.Text == txt_confirmpass_edit.Text)
                {
                    if (txt_currentpass_edit.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(
                            idUser: UserLoginCache.IdUser,
                            loginName: txt_usuario_edit.Text,

                            password: txt_Password_edit.Text,
                            firstName: txt_Nombre_edit.Text,
                            lastName: txt_Apellido_edit.Text,
                            email: txt_Email_edit.Text,
                            position: txt_position_edit.Text ,
                            telefono: Int32.Parse(txt_Telefono_edit.Text)
                             ); 
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        panel1.Visible = false;
                        
                    }
                    else
                        MessageBox.Show("Contraseña actual incorrecta");
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden");
            }
            else
                MessageBox.Show("La contraseña debe de ser de 8 caracteres minimo");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            reset();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_position_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_telefono_edit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lastName_edit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_position_edit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
