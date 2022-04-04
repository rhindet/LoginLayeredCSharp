using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DataAcces
{
    public abstract class ConectionToSql
    {
        private readonly string connectionString;

        public ConectionToSql()
        {
            
            connectionString = "Data Source=DESKTOP-V5CFQUL;Initial Catalog=MyCompany;Integrated Security=True ";
        
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}