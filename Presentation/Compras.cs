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
    public partial class Compras : Form
    {
        private bool Editar = false;
        private string idProducto = null;
        Product objetoCn = new Product();
        public Compras()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostrarCompras()
        {

            Product objetoCn = new Product();
            dataGridView1.DataSource = objetoCn.MostrarCompras();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            MostrarCompras();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    if (txtNombre.Text != "" && txtdes.Text != "" && txtMarca.Text != "" && txtPrecio.Text != "" && txtStock.Text != "" && txtTipo.Text != "" && txtProveedor.Text != "")
                    {
                        objetoCn.InsertarProductoEnCompras(txtProveedor.Text,txtNombre.Text, txtdes.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text),txtTipo.Text, Convert.ToInt32(txtCantidad.Text),DateTime.Now.ToString("dd/MM/yy"));



                        MessageBox.Show("Se ha insertado correctamente");

                        limpiarForms();

                        MostrarCompras();
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
                        //cabiar este metodo por uno nuevo que cambie la tabla de compras y no la de productos que es lo que ahora edita
                        objetoCn.EditarCompras(txtProveedor.Text,txtNombre.Text, txtdes.Text, txtMarca.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), txtTipo.Text, Convert.ToInt32(txtCantidad.Text) , Convert.ToInt32(idProducto));

                        MessageBox.Show("Se ha editado correctamente");
                        btnEditar.Show();
                        btnGuardar.Text = "Agregar";
                        MostrarCompras();
                        Editar = false;
                        limpiarForms();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro que quieres Eliminarlo?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    objetoCn.EliminarProducto(idProducto);
                    MessageBox.Show("Eliminado correctamente");
                    limpiarForms();
                    MostrarCompras();
                }

                else
                    MessageBox.Show("Seleccione una fila , Por favor");

            }

            else
                dataGridView1.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnEditar.Hide();
                btnGuardar.Text = "Guardar";
                Editar = true;
                txtProveedor.Text = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdes.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                txtTipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
                txtCantidad.Text = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();


            }
            else
                MessageBox.Show("Seleccione una fila , por favor ");
           
        }
        private void limpiarForms()
        {
            txtNombre.Clear();
            txtdes.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtTipo.Clear();
            txtCantidad.Clear();
            txtProveedor.Clear();
        }

        private void btnCancelar_edit_Click(object sender, EventArgs e)
        {
            if (Editar = true)
            {
                btnGuardar.Text = "Agregar";
                limpiarForms();
                btnEditar.Show();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

       

 }

