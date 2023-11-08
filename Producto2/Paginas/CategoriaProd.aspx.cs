using Producto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Producto2.Paginas
{
    public partial class CategoriaProd : System.Web.UI.Page
    {
        Helper Sw;
        public CategoriaProd()
        {
            Sw = new Helper();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i < 9; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                }
                DropDownList1.AutoPostBack = true;
            }
        }

        protected async void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sw.DropCat = Convert.ToInt32(DropDownList1.SelectedItem.ToString());
            try
            {
                await Sw.ObtenerDatosProductosAsync();
                var filteredProducts = Sw.ProductosCategoria();

                // Configura el origen de datos del control GridView1 para mostrar los productos filtrados.
                GridView1.DataSource = filteredProducts.Select(p => new
                {
                    ProductID = p.ProductID,
                    CategoryID = p.CategoryID,
                    ProductName = p.ProductName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitPrice = p.UnitPrice
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