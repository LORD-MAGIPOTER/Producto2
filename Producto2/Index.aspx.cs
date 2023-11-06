using Producto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Producto2
{
    public partial class Index : System.Web.UI.Page
    {

        Helper Sw;
        public Index()
        {
            Sw = new Helper();
        }

        protected async void Page_Load(object sender, EventArgs e)
        {
            try
            {
                await Sw.ObtenerDatosProductosAsync();
                GridView1.DataSource = Sw.GenerarListaProductos();
                GridView1.DataBind();

            }
            catch (Exception)
            {
                Label1.Text = Sw.Error.ToString();
            }
        }
    }
}