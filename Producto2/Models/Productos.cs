using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Producto2.Models
{
    public class Productos
    {
        public int productoid { get; set; }
        public string name { get; set; }
        public int supplier{ get; set; }
        public int categoryID { get; set; }
        public string quantityUnit { get; set; }
        public int unitPrice { get; set; }
        public int unitStore { get; set; }
        public int unitOrder { get; set;}
        public int RecorderLevel { get; set;}
        public int discontinued { get; set;}
    }
}