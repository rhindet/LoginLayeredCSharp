using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAcces;
using Common.cache;

namespace domain
{
     public class Product

    {
        private ProductDao ObjetoCD = new ProductDao();
        public DataTable MostrarProd()
        {
            
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.Mostrar();
            return tabla;
        }
        public DataTable MostrarCarrito()
        {

            DataTable tabla = new DataTable();
            tabla = ObjetoCD.MostrarCarro();
            return tabla;
        }
        public DataTable Mostrarventas()
        {
            DataTable table = new DataTable();
            table = ObjetoCD.MostrarVentas();
            return table;
        }
        public DataTable MostrarCompras()
        {
            DataTable table = new DataTable();
            table = ObjetoCD.MostrarCompras();
            return table;
        }
        public void  InsertarProducto( string nombre, string descripcion, string marca, double precio, int stock, string tipo,byte[] imagen)
        {
            
                ObjetoCD.Insertar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), tipo, imagen);

         }
        public void InsertarProductoEnCompras(string proveedor,string nombre, string descripcion, string marca, double precio, int stock, string tipo,int cantidad,string fecha)
        {

            ObjetoCD.InsertarEnCompras( proveedor,nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), tipo, Convert.ToInt32(cantidad),fecha);

        }
        public void InsertarCarrito(string nombre, string descripcion, string marca, double precio, string tipo,int cantidad )
        {

            ObjetoCD.InsertarEnCarrito(nombre, descripcion, marca, Convert.ToDouble(precio), tipo, Convert.ToInt32(cantidad));

        }
        public void EditarProducto(string nombre, string descripcion, string marca, double precio, int stock, string tipo,int id, byte[] imagen)
        {

            ObjetoCD.Editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), tipo, Convert.ToInt32(id),imagen);

        }

        public void EditarCompras(string proveedor, string  nombre, string descripcion, string marca, double precio,  int stock, string tipo, int cantidad,  int id) {
            ObjetoCD.EditarCompras(proveedor, nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), tipo, Convert.ToInt32(cantidad), Convert.ToInt32(id));
        }
        public void EliminarProducto(string id)
        {

            ObjetoCD.Eliminar(Convert.ToInt32(id));

        }
       
        public void EliminardCarrito(string id)
        {

            ObjetoCD.EliminarDeCarrito(Convert.ToInt32(id));

        }

    }
}
