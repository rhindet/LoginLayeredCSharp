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
using System.Runtime.InteropServices;
namespace Presentation
{
    public partial class usuarioVista : Form
    {
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public usuarioVista()
        {
            
            InitializeComponent();
        }
        
        
           
        

        public void usuarioVista_Load(object sender, EventArgs e)
        {
          //  btnTicket.Enabled = true;
            btnProductos.Visible = false;
            btnProductos.Enabled=false;
            panel1.Visible = false;

            btnCarrito.Visible = false;
            btnCarrito.Enabled = false;
            panel2.Visible = false ;
            LoadUserData();
            var carrito2 = new punto_de_venta();
            carrito2.MdiParent = this;
            panelContenedor.Visible = false;
            carrito2.Dock = DockStyle.Fill;
            carrito2.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void LoadUserData()
        {
            lbl_Nombre.Text = UserLoginCache.FirstName + ", " + UserLoginCache.LastName;
            lbl_Posicion.Text = UserLoginCache.Position;
            lbl_Email.Text = UserLoginCache.LoginName;
           

        }

        private void linkLabel_editar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm1 = new User_Mode();
            frm1.MdiParent = this;
            panelContenedor.Visible = false;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
        }
        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar secion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                this.Close();
            }
             
                 
                
        }


       

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres salir?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            var carrito = new Carrito();
            carrito.MdiParent = this;
            panelContenedor.Visible = false;
            carrito.Dock = DockStyle.Fill;
            carrito.Show();
           
        }
       

        public void btnProductos_Click(object sender, EventArgs e)
        {
            var productos = new SellPoint();
            productos.MdiParent = this;
            panelContenedor.Visible = false;
            productos.Dock = DockStyle.Fill;
            productos.Show();

        }
        public void MostrarPantallaProd()
        {
            var productos = new SellPoint();
            productos.MdiParent = this;
            panelContenedor.Visible = false;
            productos.Dock = DockStyle.Fill;
            productos.Show();
        }

        public void btnTicket_Click(object sender, EventArgs e)
        {
            var ticket  = new ticket();
            ticket.MdiParent = this;
            panelContenedor.Visible = false;
            ticket.Dock = DockStyle.Fill;
            ticket.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var carrito2 = new punto_de_venta();
            carrito2.MdiParent = this;
            panelContenedor.Visible = false;
            carrito2.Dock = DockStyle.Fill;
            carrito2.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            var carrito2 = new Carrito2();
            carrito2.MdiParent = this;
            panelContenedor.Visible = false;
            carrito2.Dock = DockStyle.Fill;
            carrito2.Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            btnProductos.Visible = true;
            btnProductos.Enabled = true;
            panel1.Visible = true;

            btnCarrito.Visible = true;
            btnCarrito.Enabled = true;
            panel2.Visible = true;
        }

       
    }
}
