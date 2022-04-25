using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using System.Data.SqlClient;
namespace Presentation
{
    public partial class Empleados : Form
    {
        UserModel objetoCz = new UserModel();
        public Empleados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {

            MostrarEmpleados();
        }
        private void MostrarEmpleados()
        {

            UserModel objetoCl = new UserModel();
            dataGridView1.DataSource = objetoCl.MostrarEmple();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            buscarEmployee();
        }

        private void buscarEmployee()
        {



            if (txtlastname.Text == "")
            {
                SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
                conexion.Open();
                string consulta = "select *from Users where LoginName= '" + txtname.Text + "' and Position = 'Employee' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                conexion.Close();
            }
            else
            {
                SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
                conexion.Open();
                string consulta = "select *from Users where LastName= '" + txtlastname.Text + "' and  Position = 'Employee'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                conexion.Close();
            }
            txtlastname.Clear();
            txtname.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
