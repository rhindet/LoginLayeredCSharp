using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.cache
{
     public class CarritoCache
    {
        public string id_num { get; set; }

        public string cliente = UserLoginCache.LoginName;
        public string Nombcre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Precio { get; set; }
        public string Tipo { get; set; }
        public string Cantidad { get; set; }
        public string Subtotal { get; set; }
        public string Total { get; set; }
    }
}
