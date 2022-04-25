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

namespace Presentation
{
    public partial class ReportesVenta : Form
    {
        public ReportesVenta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void ReportesVenta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            Calculos();
            

        }
        private void Calculos()
        {


            if (txtFecha.Text != "")
            {
                SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
                conexion.Open();

                string consulta = "select * from Ventas where Fecha = '" + txtFecha.Text + "' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
              
                double Suma = 0;
                double Suma2 = 0;
                int suma3 = 0;
                int suma4 = 0;
                foreach (DataRow r in dt.Rows)
                {
                    Suma = Suma + Double.Parse(r["Total"].ToString());
                }
                
                txtTotalVentas.Text = Suma.ToString();
               


                conexion.Close();
            }
            else MessageBox.Show("Ingrese una fecha");
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtTotalVentas_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
