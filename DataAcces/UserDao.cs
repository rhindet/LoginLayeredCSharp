using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.cache;



namespace DataAcces
{
    public  class UserDao:ConectionToSql
    {
        public DataTable Mostrar_clientes()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader leer;
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "BuscarClientes2";
                    command.CommandType = CommandType.StoredProcedure;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;


                }
            }
        }
        public DataTable Mostrar_empleados()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader leer;
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "Mostrar_empleados";
                    command.CommandType = CommandType.StoredProcedure;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;


                }
            }
        }

        public void editProfile(int id , string userName , string password , string name, string lastName,string Email,int telefono)
        {
            
            using (var connection = GetConnection())
            {
                connection.Open();
                
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Users set " +
                        "LoginName=@userName,Password=@pass,FirstName = @name,LastName=@lastName,Email = @email,telefono=@telefono where UserId =@id";
                    command.Parameters.AddWithValue("@userName",userName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName",lastName);
                    command.Parameters.AddWithValue("@email",Email);
                    command.Parameters.AddWithValue("@telefono",telefono);
                    command.Parameters.AddWithValue("@id",id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }
        public void EliminarSueldos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "delete from Sueldos ";
                    command.ExecuteNonQuery();
                }

            }

        }
        public void InsertarUsuarios( string userName, string password, string name, string lastName,string Position, string Email, int telefono)
        {

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "InsertarUsuarios";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginName", userName);
                    command.Parameters.AddWithValue("@Password ", password);
                    command.Parameters.AddWithValue("@FirstName", name);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.Parameters.AddWithValue("@Email ", Email);
                    command.Parameters.AddWithValue("@telefono", telefono);
                  
                    command.ExecuteNonQuery();

                }
            }
        }



        public  bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass ";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader  = command.ExecuteReader();
                    if (reader.HasRows) 
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.LoginName = reader.GetString(1);
                            UserLoginCache.Password = reader.GetString(2);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                            UserLoginCache.telefono = reader.GetInt32(7);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                 }
            }


        }

       // public void carritoAventas()
       // {
       //     using (var connection = GetConnection())
       //     {
       //         connection.Open();
       //         using (var command = new SqlCommand())
       //         {
       //             command.Connection = connection;
       //             command.CommandText = "select *from Carrito";
       //             SqlDataReader reader = command.ExecuteReader();
       //                 while (reader.Read())
       //                 {
       //                     UserLoginCache.id_num = reader.GetInt32(0);
       //                     UserLoginCache.Nombre = reader.GetString(1);
       //                     UserLoginCache.Descripcion = reader.GetString(2);
       //                     UserLoginCache.Marca = reader.GetString(3);
       //                     UserLoginCache.Precio = (float)reader.GetDouble(4);
       //                     UserLoginCache.Tipo = reader.GetString(5);
       //                     UserLoginCache.Cantidad = reader.GetInt32(6);
       //                     UserLoginCache.Subtotal = reader.GetFloat(7);
       //                     UserLoginCache.Total = reader.GetFloat(8);
       //                 }   




       //         }
       //     }
       //}
        public void AnyMethod()
        {
            if (UserLoginCache.Position == Positions.Administrador)
            {

            }
            if (UserLoginCache.Position == Positions.Manager)
            {

            }
        
            
        }

        public void  MostrarClientesFiltros()
        {
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                   




                }
            }
        }
        public DataTable MostrarSueldos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader leer;
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "select * from Sueldos";
                    //command.CommandType = CommandType.StoredProcedure;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;


                }
            }
        }


    }
}




