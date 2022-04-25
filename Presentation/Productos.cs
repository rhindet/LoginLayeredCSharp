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


namespace Presentation
{
    public partial class Productos : Form
    {
        Product  objetoCn = new Product();
        private string idProducto = null;
       

        private bool Editar = false;

        public Productos()
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
            if (UserLoginCache.Position == Positions.Administrador | (UserLoginCache.Position == Positions.Manager))
            {
                btnEliminar.Enabled = true;
            }
            else
                btnEliminar.Enabled=false;
        }

        private void MostrarProductos()
        {
          
            Product objetoCn = new Product();
            dataGridView1.DataSource = objetoCn.MostrarProd();
            
        }
      



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Editar == false)
            {
                try
                {
                    if (txtNombre.Text != "" && txtdes.Text != "" && txtMarca.Text != "" && txtPrecio.Text != "" && txtStock.Text != "" && txtTipo.Text != "")
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        ImgCli.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                        objetoCn.InsertarProducto(txtNombre.Text, txtdes.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), txtTipo.Text,ms.GetBuffer());
                       
                        
                        
                        MessageBox.Show("Se ha insertado correctamente");
                        
                        limpiarForm();
                        
                        MostrarProductos();
                    }
                    else
                        MessageBox.Show("No puede haber cajas en blanco");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por : " + ex);
                }
            }
            if (Editar == true)
            {
                if (txtNombre.Text != "" && txtdes.Text != "" && txtMarca.Text != "" && txtPrecio.Text != "" && txtStock.Text != "" && txtTipo.Text != "")
                {
                    try
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        ImgCli.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        objetoCn.EditarProducto(txtNombre.Text, txtdes.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), txtTipo.Text, Convert.ToInt32(idProducto),ms.GetBuffer());

                        MessageBox.Show("Se ha editado correctamente");
                        btnEditar.Show();
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
                else
                    MessageBox.Show("No puede haber cajas en blanco");

            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnEditar.Hide();
                btnGuardar.Text = "Guardar";
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdes.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                txtTipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();   
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                DataGridViewImageCell cell = dataGridView1.CurrentRow.Cells["imagen"] as DataGridViewImageCell;
                byte[] imagen = (byte[])cell.Value;
                ImgCli.Image = byteArrayToImage(imagen);
                



            }
            else
                MessageBox.Show("Seleccione una fila , por favor ");
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void limpiarForm()
        {
            txtNombre.Clear();
            txtdes.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtTipo.Clear();
            ImgCli.Image.Dispose();
            ImgCli.Image = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres Eliminarlo?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    objetoCn.EliminarProducto(idProducto);
                    MessageBox.Show("Eliminado correctamente");
                   
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
                btnEditar.Show();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if(rs == DialogResult.OK)
            {
                ImgCli.Image = Image.FromFile(fo.FileName);
            }
        }

        private void ImgCli_Click(object sender, EventArgs e)
        {

        }
    }
     
}
