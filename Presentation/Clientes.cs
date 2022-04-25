using DataAcces;
using domain;
using System.Data;
using System.Data.SqlClient;
namespace Presentation
{

    public partial class Clientes : Form
    {

        UserModel objetoCl = new UserModel();
        UserModel objetoCh = new UserModel();
        public Clientes()
        {
            //string texto = buscarXnombre.Text;
            InitializeComponent();

        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();


        }

        private void MostrarClientes()
        {

            UserModel objetoCl = new UserModel();
            dataGridView2.DataSource = objetoCl.MostrarClien();

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          


        }

        private void Clientes_Load_1(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            buscarCliente();



          }

        private  void buscarCliente()
        {  
            if(txtapeido.Text == "")
            {
                SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
                conexion.Open();
                string consulta = "select *from Users where LoginName= '" + txtNombre.Text + "' and Position = 'User'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView2.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                conexion.Close();
            }
            else
            {
                SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
                conexion.Open();
                string consulta = "select *from Users where LastName= '" + txtapeido.Text + "' and  Position = 'User'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView2.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                conexion.Close();
            }
            txtapeido.Clear();
            txtNombre.Clear();
        }

        private void textBox1__Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapeido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }
    }
    }
