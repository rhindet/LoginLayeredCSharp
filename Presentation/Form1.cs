using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.cache;
namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserData();

        }
        private void LoadUserData()
        {
            lbl_Nombre.Text = UserLoginCache.FirstName + ", " + UserLoginCache.LastName;
            lbl_Posicion.Text = UserLoginCache.Position;
            lbl_Email.Text = UserLoginCache.LoginName;

        }




        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres salir?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubMenuReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = true;

        }

        private void btnrptVentas_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void btnrptCompras_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void btnrptPagos_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Seguro que quieres cerrar secion?","Warning",
               MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
              this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Posicion_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }
    }
}
