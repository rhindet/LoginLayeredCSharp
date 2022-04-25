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
using Common.cache;
using domain;
namespace Presentation
{
    public partial class ReporteSueldos : Form
    {
        
        public ReporteSueldos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReporteSueldos_Load(object sender, EventArgs e)
        {
            SueldoTotal();
            MostrarSueldos();


        }
        private void MostrarSueldos()
        {

            UserModel objetoCl = new UserModel();
            dataGridView1.DataSource = objetoCl.MostrarSueld();

        }
        private void EliminarSuledos()
        {

            UserModel objetoCl = new UserModel();
            objetoCl.EliminarSueldos();

        }


        private void SueldoTotal()
        {
            UserModel objetoCl = new UserModel();
            DataTable dt = objetoCl.MostrarSueld(); 
            double Suma = 0;
            double Suma2 = 0;
            int suma3 = 0;
            int suma4 = 0;
            foreach (DataRow r in dt.Rows)
            {
                Suma = Suma + Double.Parse(r["Sueldo"].ToString());
            }
            txtTotal.Text = Suma.ToString();


        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
