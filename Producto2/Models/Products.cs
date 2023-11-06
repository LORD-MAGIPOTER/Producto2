using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Producto2.Models
{
    public class Products
    {
        public DataProductos_[] Productos { get; set; }
    }
    public class DataProductos_ { 
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set;}
        public int ReorderLevel { get; set;}
        public int Discontinued { get; set;}
    }
}