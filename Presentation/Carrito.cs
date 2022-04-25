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
using Common.cache;
using System.Data.SqlClient;


namespace Presentation
{
    public partial class Carrito : Form
    {
       
        UserModel objetoCp = new UserModel();
        Product objetoCn = new Product();
        usuarioVista objeto1 = new usuarioVista();
        private string idProducto = null;
        public Carrito()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            MostrarCarros();
           
        }
        private void MostrarCarros()
        {

            Product objetoCk = new Product();
            dataGridView1.DataSource = objetoCk.MostrarCarrito();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres Eliminarlo?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idProducto = dataGridView1.CurrentRow.Cells["id_num"].Value.ToString();
                    objetoCn.EliminardCarrito(idProducto);
                    MessageBox.Show("Eliminado correctamente");
               
                    MostrarCarros();
                }

                else
                    MessageBox.Show("Seleccione una fila , Por favor");

            }

            else
                dataGridView1.Focus();
        }
      
        private void button2_Click(object sender, EventArgs e)

        {
            UpdateInventario();
            CopiarAVentas();
            
            BorrarCarrito();
            




        }
        public void CopiarAVentas()
        {
            
            SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
            conexion.Open(); 
            string fecha = DateTime.Now.ToString();

            //hacer un textbox para que ingrese la fecha guardarlo en variables usar DateTime.Now.ToString(variable);
           // MessageBox.Show(fecha);
           // string dates = "2022/3/23";
           // DateTime Fecha = new DateTime(2022, 10, 23);
            //string  date = Fecha.ToString("dd-MM-yy");
            string selectinto = "insert Ventas  select '" + UserLoginCache.LoginName + "' , Nombre,Descripcion,Marca,Precio,Tipo,Cantidad,subtotal,Total , '" + DateTime.Now.ToString("dd/MM/yy") + "' from Carrito ";
            SqlDataAdapter adaptador = new SqlDataAdapter(selectinto, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
            MessageBox.Show("Gracias por su compra  :)");
            usuarioVista lol = new usuarioVista();
    

        }
       
        private void BorrarCarrito()
        {
            SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-V5CFQUL; Initial Catalog = MyCompany; Integrated Security = True ");
            conexion.Open();
            string delete = "delete from Carrito ";
            SqlDataAdapter adaptador = new SqlDataAdapter(delete, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
          
        }
       
        
        private void UpdateInventario()
        {
           

           

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
           


        }

        private void button2_Click_2(object sender, EventArgs e)
        {

           
        }
        public void btnProductos_Click(object sender, EventArgs e)
        {
            

        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
