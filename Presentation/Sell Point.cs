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
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Presentation
{
    public partial class SellPoint : Form
    {
        Product  objetoCa = new Product();
        private string idProducto = null;
        private bool Editar = false;

        public SellPoint()
        {
           
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Productos_Load(object sender, EventArgs e)
        {
           
            MostrarProductos();
          //  if (UserLoginCache.Position == Positions.Administrador | (UserLoginCache.Position == Positions.Manager))
            {
              //  btnEliminar.Enabled = true;
            }
          //  else
               // btnEliminar.Enabled=false;
        }
        private void ResetCombobox()
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
        }
        private void MostrarProductos()
        {
          
            Product objetoCn = new Product();
            dataGridView1.DataSource = objetoCn.MostrarProd();
            
        }
 
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
       
                try
                {
                    
                    if (txtNombre.Text != "" && txtdes.Text != "" && txtMarca.Text != "" && txtPrecio.Text != "" && txtStock.Text != "" && txtTipo.Text != "")
                    {
                        
                        objetoCa.InsertarCarrito(txtNombre.Text, txtdes.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text),  txtTipo.Text,Convert.ToInt32(comboBox1.SelectedItem));
                        
                        MessageBox.Show("Se ha insertado correctamente");
                        
                        limpiarForm();

                        comboBox1.Text = "";
                        MostrarProductos();
                        Carrito objetoCrr = new Carrito();
                       

                }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por : " + ex);
                }
            
            if (Editar == true)
            {
                if (txtNombre.Text != "" && txtdes.Text != "" && txtMarca.Text != "" && txtPrecio.Text != "" && txtStock.Text != "" && txtTipo.Text != "")
                {
                    try
                    { 
                      //  objetoCa.EditarProducto(txtNombre.Text, txtdes.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), txtTipo.Text, Convert.ToInt32(idProducto),ms.GetBuffer());

                        MessageBox.Show("Se ha editado correctamente");
                       // btnEditar.Show();
                        btnGuardar.Text = "Agregar";
                        MostrarProductos();
                        Editar = false;
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos por : " + ex);
                    }
                }
               

            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }
        public void limpiarForm()
        {
            txtNombre.Clear();
            txtdes.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtTipo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres Eliminarlo?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    objetoCa.EliminarProducto(idProducto);
                    MessageBox.Show("Eliminado correctamente");
                    limpiarForm();
                    MostrarProductos();
                }
                
                else
                    MessageBox.Show("Seleccione una fila , Por favor");

            }

            else
                dataGridView1.Focus();
        }
                
                

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_edit_Click(object sender, EventArgs e)
        {
            if(Editar = true)
            {
                btnGuardar.Text = "Agregar";
                limpiarForm();
              //  btnEditar.Show();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
              //  btnEditar.Hide();
              //  btnGuardar.Text = "Guardar";
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdes.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                txtTipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

                txtNombre.Enabled = false;
                txtMarca.Enabled = false;
                txtPrecio.Enabled = false;
                txtTipo.Enabled = false;
                txtStock.Enabled = false;
                txtdes.Enabled = false;


            }
            else
                MessageBox.Show("Seleccione una fila , por favor ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
     
}
