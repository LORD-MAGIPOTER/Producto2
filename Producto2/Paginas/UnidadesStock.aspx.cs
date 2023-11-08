using Producto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Producto2.Paginas
{
    public partial class UnidadesStock : System.Web.UI.Page
    {
        Helper Hw;

        public UnidadesStock()
        {
            Hw = new Helper();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i <= 40; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                }
                DropDownList1.AutoPostBack = true;
            }
        }

        protected async void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hw.DropStock = Convert.ToInt16(DropDownList1.SelectedItem.ToString());

            try
            {
                await Hw.ObtenerDatosProductosAsync();
                var filteredProducts = Hw.ProductosStock();

                // Configura el origen de datos del control GridView1 para mostrar los productos filtrados.
                GridView1.DataSource = filteredProducts.Select(p => new
                {
                    ProductID = p.ProductID,
                    CategoryID = p.CategoryID,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice
                });
                GridView1.DataBind();
            }
            catch (Exception)
            {
                Label1.Text = Hw.Error;
            }
        }
    }
}