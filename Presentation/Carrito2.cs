using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common.cache;

namespace Presentation
{
    public partial class Carrito2 : Form
    {
       
        string[] arrayNombres = new string[20];
        int index = 0;
        
        public Carrito2()
        {
            InitializeComponent();

        }

        private void Carrito2_Load(object sender, EventArgs e)
        {
            Mostrardatos();
           
            
           
           
           

        }
        public void Mostrardatos()
        {
            SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
            conexion.Open();

            string consulta = "select * from Carrito ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            string Suma;
            int suma3 = 0;
            int suma4 = 0;
            int suma5 = 0;
            int suma6 = 0;
            int suma7 = 0;
            int suma8 = 0;
            int suma10 = 0;
            int sumaPrecio = 0;
            int suma11 =0;
            int sumaPrecio2 = 0;
            foreach (DataRow r in dt.Rows)
            {


                SqlConnection conexions = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexions.Open();
                string consultaa = "select imagen from Carrito ";
                SqlDataAdapter adaptadorr = new SqlDataAdapter(consultaa, conexions);
                DataTable dtt = new DataTable();
                DataSet ds = new DataSet("Carrito");
                byte[] MisDatos = new byte[0];
                adaptadorr.Fill(ds, "Carrito");
                DataRow myRow = ds.Tables["Carrito"].Rows[0];
                MisDatos = (byte[])r["imagen"];
                MemoryStream mss = new MemoryStream(MisDatos);

                var picture = new PictureBox
                {

                    Name = "pictureBox",
                    Size = new Size(302, 250),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent,
                    Location = new Point(180, 120+suma6),
                    Image = Image.FromStream(mss)
                    

                };
                suma6 = suma6 + 400;
                this.Controls.Add(picture);
              
               


                Label lbl2 = new Label();

                lbl2.Location = new Point(651, 152+suma3);
                suma3 = suma3 + 400;
                lbl2.BackColor = Color.Transparent;
                lbl2.TextAlign = ContentAlignment.TopLeft;
                lbl2.Size = new Size(263, 58);

                this.Controls.Add(lbl2);
                lbl2.BringToFront();
                lbl2.Text = r["Nombre"].ToString();
                arrayNombres[index] = lbl2.Text;
               
                index++;





                Label lbl3 = new Label();

                lbl3.Location = new Point(651, 250+suma4);
                suma4 = suma4 + 400;
                lbl3.BackColor = Color.Transparent;
                lbl3.TextAlign = ContentAlignment.TopLeft;
                lbl3.Size = new Size(700, 58);

                this.Controls.Add(lbl3);
                lbl3.BringToFront();
                lbl3.Text = r["Descripcion"].ToString();


                Label lbl4 = new Label();

                lbl4.Location = new Point(820 , 350 + suma5);
                suma5 = suma5 + 400;
                lbl4.BackColor = Color.Transparent;
                lbl4.TextAlign = ContentAlignment.TopLeft;
                lbl4.Size = new Size(60, 58);
                Font fuente3 = new Font("Century  Gothic", 7, FontStyle.Bold);
                lbl4.Font = fuente3;
                this.Controls.Add(lbl4);
                lbl4.BringToFront();
                lbl4.Text = r["Cantidad"].ToString();




                Label lbl4_1 = new Label();

                lbl4_1.Location = new Point(651, 350 + suma11);
                suma11 = suma11 + 400;
                lbl4_1.BackColor = Color.Transparent;
                lbl4_1.TextAlign = ContentAlignment.TopLeft;
                lbl4_1.Size = new Size(263, 58);
               
                lbl4_1.Font = fuente3;
                this.Controls.Add(lbl4_1);
                lbl4_1.BringToFront();
                lbl4_1.Text = "Cantidad:";




                Panel panel1 = new Panel();
                panel1.Location = new Point(12, 81+suma10);
                panel1.Size = new Size(1862, 9);
                panel1.ForeColor = Color.Black;
                panel1.BackColor = Color.DarkGray;
                // Set the Borderstyle for the Panel to three-dimensional.
                suma10 = suma10 + 400;
                this.Controls.Add(panel1);





                //Label lbl9 = new Label();

                //lbl9.Location = new Point(100, 78 + suma10);
                
                //lbl9.Size = new Size(3100, 48);
                //lbl9.BackColor = Color.Transparent;
                //lbl9.Text = "-------------------------------------------------------------------------------------------------------------------------------";
                //this.Controls.Add(lbl9);

                this.Controls.Add(lbl4);
                lbl4.BringToFront();
               
                lbl4.Text = r["Cantidad"].ToString();


                Label lblprecio = new Label();

                lblprecio.Location = new Point(1580 , 230 + sumaPrecio);
                sumaPrecio = sumaPrecio + 400;
                lblprecio.BackColor = Color.Transparent;
                lblprecio.TextAlign = ContentAlignment.MiddleCenter;
                lblprecio.Size = new Size(40, 90);
                Font fuente2 = new Font("Century  Gothic", 15, FontStyle.Regular);
                lblprecio.Font = fuente2;
                this.Controls.Add(lblprecio);
                lblprecio.BringToFront();
                lblprecio.Text = "$";


                Label lblprecio2 = new Label();

                lblprecio2.Location = new Point(1670, 140 + sumaPrecio2);
                sumaPrecio2 = sumaPrecio2 + 400;
                lblprecio2.BackColor = Color.Transparent;
                lblprecio2.TextAlign = ContentAlignment.MiddleCenter;
                lblprecio2.Size = new Size(40, 90);
                lblprecio2.ForeColor= Color.Gray;
                this.Controls.Add(lblprecio2);
                lblprecio2.BringToFront();
                lblprecio2.Text = "$";
              




                Label lbl5 = new Label();

                lbl5.Location = new Point(1700, 160 + suma7);
                suma7 = suma7 + 400;
                lbl5.BackColor = Color.Transparent;
                lbl5.TextAlign = ContentAlignment.TopLeft;
                lbl5.Size = new Size(100, 58);
                lbl5.ForeColor = Color.Gray;
                this.Controls.Add(lbl5);
                lbl5.BringToFront();
                lbl5.Text = r["subtotal"].ToString();



                Label lbl6 = new Label();

                lbl6.Location = new Point(1629, 250 + suma8);
                suma8 = suma8 + 400;
                lbl6.BackColor = Color.Transparent;
                lbl6.TextAlign = ContentAlignment.TopLeft;
                lbl6.Size = new Size(200, 58);

                this.Controls.Add(lbl6);
                lbl6.BringToFront();
                lbl6.Text = r["Total"].ToString();
                Font fuente = new Font("Century  Gothic", 12, FontStyle.Bold);
                lbl6.Font = fuente;






                conexions.Close();
            }

          
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
        }
        public void CopiarAVentas()
        {
           
                SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
            conexion.Open();
            string fecha = DateTime.Now.ToString();
            var command = new SqlCommand();
            //hacer un textbox para que ingrese la fecha guardarlo en variables usar DateTime.Now.ToString(variable);
            // MessageBox.Show(fecha);
            // string dates = "2022/3/23";
            // DateTime Fecha = new DateTime(2022, 10, 23);
            //string  date = Fecha.ToString("dd-MM-yy");
            string selectinto = "insert Ventas  select '" + UserLoginCache.LoginName + "' , Nombre,Descripcion,Marca,Precio,Tipo,Cantidad,subtotal,Total , '" + DateTime.Now.ToString("dd/MM/yy") + "' from Carrito ";
            SqlCommand cmd = new SqlCommand("Select * from Carrito", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(selectinto, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            SqlDataReader leer;
            leer = cmd.ExecuteReader();
                

            if (leer.Read()) {
                if (MessageBox.Show("Deseas generar ticket?", "Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ticket ticket = new ticket();
                    ticket.Show();
                }
                MessageBox.Show("Gracias por su compra  :)");
            }
            else MessageBox.Show("Favor de llenar carrito ");

            conexion.Close();
            
            usuarioVista lol = new usuarioVista();
            comprar.Enabled = false;



        }
        private void BorrarCarrito()
        {
            SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
            conexion.Open();
            string delete = "delete from Carrito ";
            SqlDataAdapter adaptador = new SqlDataAdapter(delete, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            
            conexion.Close();
            usuarioVista usuariovista = new usuarioVista();
            



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comprar_Click(object sender, EventArgs e)
        {
            CopiarAVentas();
            BorrarCarrito();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BorrarCarrito();

           
        }
       

       
    }
}
