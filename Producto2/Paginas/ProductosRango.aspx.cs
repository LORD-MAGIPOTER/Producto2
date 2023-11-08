using Producto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Producto2.Paginas
{
    public partial class ProductosRango : System.Web.UI.Page
    {

        Helper Sw;
        public ProductosRango()
        {
            Sw = new Helper();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            Sw.PrecioN = Convert.ToInt32(TextBox1.Text);
            Sw.PrecioD = Convert.ToInt32(TextBox2.Text);

            try
            {
                await Sw.ObtenerDatosProductosAsync();
                var filteredProducts = Sw.PrecioProductos();

                GridView1.DataSource = filteredProducts.Select(p => new
                {
                    ProductID = p.ProductID,
                    CategoryID = p.CategoryID,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                });
                GridView1.DataBind();
            }
            catch (Exception)
            {
                Label1.Text = Sw.Error;
            }
        }
    }
}