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
    public partial class ventas : Form
    {
      
        public ventas()
        {
            InitializeComponent();
         
        }

        private void ventas_Load(object sender, EventArgs e)
        {

           
            MostrarVentas();
        

        }
        public void maxi()
        {
            Form1 frm1 = new Form1();
            if (frm1.WindowState == FormWindowState.Maximized)
            {
                dataGridView1.Size = new Size(3425, 5000);
            }
            else
            {
                MessageBox.Show("nop");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarVentas()
        {
           
            Product objetoCn = new Product();
            dataGridView1.DataSource = objetoCn.Mostrarventas();

        }

    }
}
