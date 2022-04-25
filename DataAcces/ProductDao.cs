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
     public class ProductDao : ConectionToSql
    {
        public DataTable Mostrar()
        {
               using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader leer;
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "MostrarProductos";
                    command.CommandType = CommandType.StoredProcedure;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;


                }
            }
        }
        public DataTable MostrarVentas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader leer;
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "select * from Ventas";
                    //command.CommandType = CommandType.StoredProcedure;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;


                }
            }
        }
       
        public DataTable MostrarCarro()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader leer;
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "select *from Carrito";
                    
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;


                }
            }
        }
        public DataTable MostrarCompras()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader leer;
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "select *from compras";

                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;


                }
            }
        }
        public void Insertar(string nombre, string descripcion,string marca,double precio,int stock,string tipo, byte[]imagen)
        {
            using (var connection = GetConnection())
            {
               connection.Open(); 
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "IngresarProductos2";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre",nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@imagen", imagen);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();


                }

            }
        }
        public void InsertarVentas(string nombre, string descripcion, string marca, double precio, int stock, string tipo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "InsertarProductos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@tipo", tipo);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();


                }

            }
        }
        public void InsertarEnCarrito(string nombre, string descripcion, string marca, double precio,  string tipo,int cantidad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "IngresarACarritos9";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                   
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();


                }

            }
        }
        public void InsertarEnCompras(string proveedor,string nombre, string descripcion, string marca, double precio, int stock, string tipo, int cantidad,string fecha)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "IngresarCompras4";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Proveedor", proveedor);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@date", fecha);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();


                }

            }
        }
        public void Editar(string nombre, string descripcion, string marca, double precio, int stock, string tipo,int id, byte[] imagen)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "EditarProductos2";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@imagen", imagen);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();



                }

            }

        }
        public void EditarCompras(string proveedor, string nombre, string descripcion, string marca, double precio, int stock, string tipo, int cantidad,int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "update compras set " +
                        "Proveedor=@proveedor,Nombre=@Nombre,Descripcion = @Descripcion,Marca=@Marca,Precio =@Precio,Cantidad=@cantidad,Stock=@stock,Tipo=@Tipo where id =@id"; 
                   
                    command.Parameters.AddWithValue("@Proveedor", proveedor);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    
                    command.Parameters.Clear();



                }

            }

        }
        public void Eliminar(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "EliminarProducto";
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@idpro", id);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();



                }
                
            }

        }
       
        public void EliminarDeCarrito(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //por alguna razon  command.Connection = connection; es nesesario para que   command.ExecuteNonQuery(); no salte error//
                    command.Connection = connection;
                    command.CommandText = "EliminarDeCarritos";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idprod", id);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();



                }

            }

        }


    }
}
