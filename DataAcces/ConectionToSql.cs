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
        public readonly string   connectionString;

        public  ConectionToSql()
        {
           
          connectionString = "Data Source=DESKTOP-V5CFQUL;Initial Catalog=MyCompany;Integrated Security=True ";
          
        
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        

    }

}   