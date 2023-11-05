using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Producto2.Models
{
    public class Products
    {
        public DataProductos_[] ProductosDatos { get; set; }
    }
    public class DataProductos_ { 
        public int productoid { get; set; }
        public string name { get; set; }
        public int supplier{ get; set; }
        public int categoryID { get; set; }
        public string quantityUnit { get; set; }
        public int unitPrice { get; set; }
        public int unitStock { get; set; }
        public int unitOrder { get; set;}
        public int ReorderLevel { get; set;}
        public int discontinued { get; set;}
    }
}