using Producto2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Producto2.Paginas
{
    public partial class Paises : System.Web.UI.Page
    {
        Helper Sw;
        public Paises()
        {
            Sw = new Helper();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> DropPaises =
               new List<string> {
            "Seleccionar País",
            "Germany",
            "Mexico",
            "Sweden",
            "France",
            "Spain",
            "Canada",
            "Argentina",
            "Switzerland",
            "Austria",
            "Brazil",
            "Italy",
            "Portugal",
            "USA",
            "Venezuela",
            "Ireland",
            "Belgium",
            "Austria",
            "Norway",
            "Denmark",
            "Finland",
            "Poland"
        };

            if (!IsPostBack)
            {
                for (int i = 0; i < DropPaises.Count; i++)
                {
                    DropDownList1.Items.Add(new ListItem(DropPaises[i], DropPaises[i]));
                }
                DropDownList1.AutoPostBack = true;
            }
        }

        protected async void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sw.DropPais = Convert.ToString(DropDownList1.SelectedItem.ToString());

            try
            {
                await Sw.ObtenerDatosClientesAsync();
                var filteredClients = Sw.InfoClient();

                GridView1.DataSource = filteredClients.Select(p => new
                {
                    CustomerID = p.CustomerID,
                    CompanyName = p.CompanyName,
                    Address = p.Address,
                    City = p.City,
                    Phone = p.Phone,
                    Fax = p.Fax
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