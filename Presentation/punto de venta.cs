using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Presentation
{
    public partial class punto_de_venta : Form
    { /* SqlConnection cn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;*/
        string[] arrayNombres = new string[20];
        string[] arrayImagen = new string[20];
        
        int index = 0;

        Product objetoCa = new Product();
        public punto_de_venta()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void punto_de_venta_Load(object sender, EventArgs e)
        {
            this.SetStyle(
             ControlStyles.UserPaint |
             ControlStyles.AllPaintingInWmPaint |
             ControlStyles.OptimizedDoubleBuffer, true);
            Mostrardatos();
        }

        public void Mostrardatos() {
            SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
            conexion.Open();

            string consulta = "select * from Productos ";
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
            int sumaA = 0;
            int sumaB= 0;
            int sumaC= 0;
            int sumaD = 0;
            int sumaE = 0;
            int sumaF = 0;
            int sumaG = 0;
            int sumaH = 0;
            int sumaI = 0;
            int sumaJ = 0;

            int sumaPrecio = 0;
            foreach (DataRow r in dt.Rows)
            {

                if (index == 8)
                {
                    sumaA =1000;
                    sumaB = 950;
                    sumaC = 950;
                    sumaD = 950;
                    sumaE = 1050;
                    sumaF = 20;
                    sumaG = 20;
                    sumaH = 20;
                    sumaI = 20;
                    sumaJ = 20;
                    suma3 = -10;
                    suma6 = -10;
                    suma4 = -10;
                    sumaPrecio =-5;
                    suma5= -5;
                }
              

                //var imgPictureBox = new PictureBox();
                //imgPictureBox.Location = new System.Drawing.Point(15, 89);
                //imgPictureBox.Size = new System.Drawing.Size(140, 140);
                //imgPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                //byte[] img = (byte[])r["imagen"];
                //System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                //imgPictureBox.Image = System.Drawing.Bitmap.FromStream(ms);

                //Controls.Add(imgPictureBox);
                //imgPictureBox.Visible = true;



                Label lbl2 = new Label();

                lbl2.Location = new Point(100 + suma3, 470 + sumaA);
                suma3 = suma3 + 400;
                lbl2.BackColor = Color.Transparent;
                lbl2.TextAlign = ContentAlignment.MiddleCenter;
                lbl2.Size = new Size(263, 58);

                this.Controls.Add(lbl2);
                lbl2.BringToFront();
                lbl2.Text = r["Nombre"].ToString();


                arrayNombres[index] = lbl2.Text;
                



                Label lblprecio = new Label();

                lblprecio.Location = new Point(140 + sumaPrecio, 690+sumaB);
                sumaPrecio = sumaPrecio + 400;
                lblprecio.BackColor = Color.Transparent;
                lblprecio.TextAlign = ContentAlignment.MiddleCenter;
                lblprecio.Size = new Size(40, 90);

                this.Controls.Add(lblprecio);
                lblprecio.BringToFront();
                lblprecio.Text = "$";





                Label lbl3 = new Label();

                lbl3.Location = new Point(100 + suma4, 600+sumaC);
                suma4 = suma4 + 400;
                lbl3.BackColor = Color.Transparent;
                lbl3.TextAlign = ContentAlignment.MiddleCenter;
                lbl3.Size = new Size(263, 100);

                this.Controls.Add(lbl3);
                lbl3.BringToFront();
                lbl3.Text = r["Descripcion"].ToString();


                Label lbl4 = new Label();

                lbl4.Location = new Point(180 + suma5, 700+sumaD);
                suma5 = suma5 + 400;
                lbl4.BackColor = Color.Transparent;
                lbl4.TextAlign = ContentAlignment.MiddleLeft;
                lbl4.Size = new Size(110, 85);
                Font fuente = new Font("Century  Gothic", 12, FontStyle.Regular);
                lbl4.Font = fuente;

                this.Controls.Add(lbl4);
                lbl4.BringToFront();
                lbl4.Text = r["Precio"].ToString();
                // Suma =(r["Nombre"].ToString());
                //label1.Text = Suma.ToString();
                
                SqlConnection conexions = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexions.Open();
                string consultaa = "select imagen from Productos ";
                SqlDataAdapter adaptadorr = new SqlDataAdapter(consultaa, conexions);
                DataTable dtt = new DataTable();
                DataSet ds = new DataSet("Productos");
                byte[] MisDatos = new byte[0];
                adaptadorr.Fill(ds, "Productos");
                DataRow myRow = ds.Tables["Productos"].Rows[0];
                MisDatos = (byte[])r["imagen"];
                MemoryStream mss = new MemoryStream(MisDatos);
                arrayImagen[index] = Image.FromStream(mss).ToString();
                index++;

                var picture = new PictureBox
                {
                      
                        Name = "pictureBox",
                        Size = new Size(400, 200),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(30+suma6, 200+sumaE),
                        Image = Image.FromStream(mss)

                };

                suma6 = suma6 + 400;
                this.Controls.Add(picture);
                    //pictureBox1.Image = Image.FromStream(mss);
                    // pictureBox1.Image = Image.FromFile(@"C:\Users\Admin\Downloads\d.png"); //Image.FromStream(ms);

                 conexions.Close();
               

            }
            
            conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        public void verImagen()
        {
           


        }

        private void Agregar1_Click(object sender, EventArgs e)
        {
                    if(comboBox1.Text != "")
                    {
                         SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                        conexion2.Open();


                        string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox1.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[0] + "'";

                        // MessageBox.Show(hola2);
                        SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                        DataTable dt = new DataTable();
                        adaptador2.Fill(dt);

                        conexion2.Close();
                        comboBox1.Text = "";
                        MessageBox.Show("Se ha insertado correctamente");

                    }
                    else
                    {
                      MessageBox.Show("Ingrese la cantidad, Porfavor");
                    }




         
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexion2.Open();


                string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox2.SelectedItem) + "' ,imagen from Productos where Nombre='" + arrayNombres[1] + "'";


                SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                DataTable dt = new DataTable();
                adaptador2.Fill(dt);

                conexion2.Close();
                comboBox2.Text = "";


                MessageBox.Show("Se ha insertado correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad, Porfavor");
            }
          


        }
         


    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregar3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexion2.Open();


                string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox3.SelectedItem) + "' ,imagen from Productos where Nombre='" + arrayNombres[2] + "'";

                // MessageBox.Show(hola2);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                DataTable dt = new DataTable();
                adaptador2.Fill(dt);

                conexion2.Close();
                comboBox3.Text = "";


                MessageBox.Show("Se ha insertado correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad, Porfavor");
            }
            
        }

        private void agregar4_Click(object sender, EventArgs e)

        {
            if (comboBox4.Text != "")
            {
                SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexion2.Open();


                string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox4.SelectedItem) + "' ,imagen from Productos where Nombre='" + arrayNombres[3] + "'";

                // MessageBox.Show(hola2);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                DataTable dt = new DataTable();
                adaptador2.Fill(dt);

                conexion2.Close();
                comboBox4.Text = "";


                MessageBox.Show("Se ha insertado correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad, Porfavor");
            }
           
        }

        private void agregar5_Click(object sender, EventArgs e)
        {
            if(comboBox5.Text != "")
            {
                SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexion2.Open();


                string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox5.SelectedItem) + "' ,imagen from Productos where Nombre='" + arrayNombres[4] + "'";

                // MessageBox.Show(hola2);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                DataTable dt = new DataTable();
                adaptador2.Fill(dt);

                conexion2.Close();
                comboBox5.Text = "";


                MessageBox.Show("Se ha insertado correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad, Porfavor");
            }
            
        }

        private void agregar6_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text != "")
            {
                SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexion2.Open();


                string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox6.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[5] + "'";

                // MessageBox.Show(hola2);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                DataTable dt = new DataTable();
                adaptador2.Fill(dt);

                conexion2.Close();
                comboBox6.Text = "";


                MessageBox.Show("Se ha insertado correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad, Porfavor");
            }
     
        }

        private void agregar7_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text != "")
            {
                SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexion2.Open();


                string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox7.SelectedItem) + "' ,imagen from Productos where Nombre='" + arrayNombres[6] + "'";

                // MessageBox.Show(hola2);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                DataTable dt = new DataTable();
                adaptador2.Fill(dt);

                conexion2.Close();
                comboBox7.Text = "";


                MessageBox.Show("Se ha insertado correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad, Porfavor");
            }
        }

        private void agregar8_Click(object sender, EventArgs e)

        {
            if(comboBox8.Text != "")
            {
                SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

                conexion2.Open();


                string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox8.SelectedItem) + "' ,imagen from Productos where Nombre='" + arrayNombres[7] + "'";

                // MessageBox.Show(hola2);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
                DataTable dt = new DataTable();
                adaptador2.Fill(dt);

                conexion2.Close();
                comboBox8.Text = "";


                MessageBox.Show("Se ha insertado correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad, Porfavor");
            }
          
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[0] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";




            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[1] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[2] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[3] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[4] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[5] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[6] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[7] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[8] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[9] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[10] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[11] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[12] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[13] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[14] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + 1 + "',imagen  from Productos where Nombre='" + arrayNombres[15] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox1.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox16.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[8] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox16.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox15.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[9] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox15.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox14.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[10] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox14.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox13.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[11] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox13.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox12.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[12] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox12.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox11.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[13] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox11.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox10.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[14] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox10.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion2 = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");

            conexion2.Open();


            string consulta2 = "insert Carrito  select  Nombre,Descripcion,Marca,Precio ,Tipo ,'" + Convert.ToInt32(comboBox9.SelectedItem) + "',imagen  from Productos where Nombre='" + arrayNombres[15] + "'";

            // MessageBox.Show(hola2);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion2);
            DataTable dt = new DataTable();
            adaptador2.Fill(dt);

            conexion2.Close();
            comboBox9.Text = "";
            MessageBox.Show("Se ha insertado correctamente");
        }
    }
}
