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
        ventas venta = new ventas();
        public Form1()
        {
            InitializeComponent();
            
        }
        Compras compras = new Compras();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            LoadUserData();
            ManagerLogin();
            EmployeeLogin();


        }
        private void ManagerLogin()
        {
            if (UserLoginCache.Position == Positions.Manager)
            {

             
            }
        }
      
        private void EmployeeLogin()
        {
            if (UserLoginCache.Position == Positions.Employee)
            {
                btn_Compras.Enabled = false;
                btnReporte.Enabled = false;
                button5.Enabled = false;



            }
        }
        private void LoadUserData()
        {
            lbl_Nombre.Text = UserLoginCache.FirstName + ", " + UserLoginCache.LastName;
            lbl_Posicion.Text = UserLoginCache.Position;
            lbl_Email.Text = UserLoginCache.LoginName;

        }




        private void btnCerrar_Click(object sender, EventArgs e)
        {
          

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
               
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productos = new Productos();
            productos.MdiParent = this;
            panelContenedor.Visible = false;
            productos.Dock = DockStyle.Fill;
            productos.Show();
            SubMenuReportes.Visible = false;
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
            var ReporteVentas = new ReportesVenta();
            ReporteVentas.MdiParent = this;
            panelContenedor.Visible = false;
            ReporteVentas.Dock = DockStyle.Fill;
            ReporteVentas.Show();


        }

        private void btnrptCompras_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
         
            var ReporteCompras = new ReportesCompra();
            ReporteCompras.MdiParent = this;
            panelContenedor.Visible = false;
            ReporteCompras.Dock = DockStyle.Fill;
            ReporteCompras.Show();
        }

        private void btnrptPagos_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;

            var ReportePagos = new ReporteSueldos();
            ReportePagos.MdiParent = this;
            panelContenedor.Visible = false;
            ReportePagos.Dock = DockStyle.Fill;
            ReportePagos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ventas = new ventas();
            ventas.MdiParent = this;
            panelContenedor.Visible = false;
            ventas.Dock = DockStyle.Fill;
            ventas.Show();
            SubMenuReportes.Visible = false;
        }

        private void lbl_Posicion_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_editar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm1 = new User_Mode();
            frm1.MdiParent = this;
            panelContenedor.Visible = false;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
            var clientes = new Clientes();
            clientes.MdiParent = this;
            panelContenedor.Visible = false;
            clientes.Dock = DockStyle.Fill;
            clientes.Show();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres salir?", "Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            pictureBox2.Location = new Point(1341, 374);
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            pictureBox2.Location = new Point(1500, 700);

            

    


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar secion?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                  this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
            var empleados = new Empleados();
            empleados.MdiParent = this;
            panelContenedor.Visible = false;
            empleados.Dock = DockStyle.Fill;
            empleados.Show();
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
            var compras = new Compras();
            compras.MdiParent = this;
            panelContenedor.Visible = false;
            compras.Dock = DockStyle.Fill;
            compras.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
  
            }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
        }
    }
}
