using Producto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Producto2.Models.Products;

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
                for (int i = 0; i <= 100; i++)
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
                ProductoStock.DataSource = Hw.ProductosStock();
                ProductoStock.DataBind();
            }
            catch (Exception)
            {
                Label1.Text = Hw.Error;
            }
        }
    }
}