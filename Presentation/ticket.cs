using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ticket : Form
    {
        int index = 0;
        public ticket()
        {
            InitializeComponent();
        }

        private void lblsubtotal_Click(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ticket_Load(object sender, EventArgs e)

        {
            //DataTable dt = Ticket();
            //dataGridView1.DataSource = dt;
            lblfecha.Text = DateTime.Now.ToString("D");
            labelhora.Text= DateTime.Now.ToString("T");
            TicketTotal();
            select();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void select()
        {

            SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
            conexion.Open();
            string fecha = DateTime.Now.ToString();

         
            string selectinto = " select Nombre,Cantidad,Total from Carrito";
            SqlDataAdapter adaptador = new SqlDataAdapter(selectinto, conexion);
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public static DataTable Ticket()
        {
            String strCn = "Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ";
            using (SqlConnection cn = new SqlConnection(strCn))
            {
                cn.Open();
                string sql = "SELECT * FROM Carrito";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

        }
        private void TicketTotal()
        {
            DataTable dt = Ticket();
            double Suma = 0;
            double Suma2= 0;
            int suma3 = 0;
            int suma4 = 0;
            int sumaA = 0;
            int sumaB = 50;
            foreach (DataRow r in dt.Rows)
            {

                index++;

                Label lbl2 = new Label();

                lbl2.Location = new Point(500, 700 + suma3);
                suma3 = suma3 + 100;
                lbl2.BackColor = Color.Gray;
                lbl2.TextAlign = ContentAlignment.MiddleCenter;
                lbl2.Size = new Size(263, 58);
               
                this.Controls.Add(lbl2);
                lbl2.BringToFront();
                lbl2.Text = r["Nombre"].ToString();

                Label lbl3 = new Label();

                lbl3.Location = new Point(1000, 600 + suma3);

                lbl3.BackColor = Color.Gray;
                lbl3.TextAlign = ContentAlignment.MiddleCenter;
                lbl3.Size = new Size(263, 58);
              
                this.Controls.Add(lbl3);
                lbl3.BringToFront();
                lbl3.Text = r["Cantidad"].ToString();


                Label lbl4= new Label();

                lbl4.Location = new Point(1450, 600 + suma3);

                lbl4.BackColor = Color.Gray;
                lbl4.TextAlign = ContentAlignment.MiddleCenter;
                lbl4.Size = new Size(263, 58);
            
                this.Controls.Add(lbl4);
                lbl4.BringToFront();
                
                lbl4.Text = r["subtotal"].ToString();


               




                Suma = Suma + Double.Parse(r["Total"].ToString());
                Suma2= Suma2+ Double.Parse(r["subtotal"].ToString());
            
            if (index > 6)
                {
                    panel1.Size = new Size(1409, 1536+sumaB);
                    sumaA = 600 + suma3 +90;
                    sumaB = sumaB + 100;
                }
            }
            //label8.Location = new Point(500, sumaA + 100);
            //label9.Location = new Point(500, sumaA + 100);
            //label8.BackColor = Color.Red;
            //label9.BackColor = Color.Red;

            if (index > 6)
            {
                lbltotal.Visible = false;
                lblsubtotal.Visible = false;
                lbltot.Visible = false;
                lblsub.Visible=false;
                labelLinea.Visible=false;


               
                Label lblb = new Label();

                lblb.Location = new Point(1200, sumaA+20);

                lblb.BackColor = Color.Gray;
                lblb.TextAlign = ContentAlignment.MiddleCenter;
                lblb.Size = new Size(263, 40);
                this.Controls.Add(lblb);
                lblb.BringToFront();
                Font fuente2 = new Font("Century  Gothic", 8, FontStyle.Bold);
                lblb.Font = fuente2;
                lblb.Text = "Subtotal:";

               

                Label lblc = new Label();

                lblc.Location = new Point(1200, sumaA + 100);

                lblc.BackColor = Color.Gray;
                lblc.TextAlign = ContentAlignment.MiddleCenter;
                lblc.Size = new Size(263, 58);
                this.Controls.Add(lblc);
                lblc.BringToFront();
                Font fuente4 = new Font("Century  Gothic", 12, FontStyle.Bold);
                lblc.Font = fuente4;
                lblc.Text = "Total:";




                Label lbl0 = new Label();

                lbl0.Location = new Point(1450, sumaA + 100);

                lbl0.BackColor = Color.Gray;
                lbl0.TextAlign = ContentAlignment.MiddleCenter;
                lbl0.Size = new Size(263, 58);
                this.Controls.Add(lbl0);
                lbl0.BringToFront();
                lbl0.Text = Suma.ToString();



                Label lbla = new Label();
                lbla.Location = new Point(1450, sumaA+10);
                lbla.BackColor = Color.Gray;
                lbla.TextAlign = ContentAlignment.MiddleCenter;
                lbla.Size = new Size(263, 58);
                this.Controls.Add(lbla);
                lbla.BringToFront();
                lbla.Text = Suma2.ToString();

                Label lbld = new Label();

                lbld.Location = new Point(500, sumaA - 30);

                lbld.BackColor = Color.Gray;
                lbld.TextAlign = ContentAlignment.MiddleCenter;
                lbld.Size = new Size(1305, 40);
                this.Controls.Add(lbld);
                lbld.BringToFront();
                Font fuente = new Font("Century  Gothic", 12, FontStyle.Bold);
                lbld.Font = fuente;

                lbld.Text = "------------------------------------------------------------------------------------";







            }
            else
            {
                lbltotal.Text = Suma.ToString();
                lblsubtotal.Text = Suma2.ToString();
            }
        
           

            

        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
