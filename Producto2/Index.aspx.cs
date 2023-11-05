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
            try {
                await Sw.ObtenerDatosProductosAsync();
                Label2.Text = Sw.productoID().ToString();
                Label3.Text = Sw.name();
                Label4.Text = Sw.supplier().ToString();
                Label5.Text = Sw.categoryid().ToString();
                Label6.Text = Sw.quantityUnit();
                Label7.Text = Sw.unitPrice().ToString();
                Label8.Text = Sw.unitStore().ToString();
                Label9.Text = Sw.unitOrder().ToString();
                Label10.Text = Sw.RecorderLevel().ToString();
                Label11.Text = Sw.discontinued().ToString();
            }
            catch (Exception)
            {
                Label1.Text = Sw.Error;
            }
        }
    }
}