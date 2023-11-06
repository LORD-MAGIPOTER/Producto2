using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Producto2.Models
{
    public class Helper
    {
        Products Producto;
        public string Error { get; set; }
        string DirBase;

        HttpMessageHandler HandlerProducto;

        public Helper() { 
            HandlerProducto = new HttpClientHandler();
        }

        public async Task ObtenerDatosProductosAsync()
        {
            DirBase = "https://run.mocky.io";
            string SolicitudClienteURI = "v3/9ff137b9-68f1-483f-b717-69991c46b2bc";

            try
            {
                using (var Cliente = new HttpClient(HandlerProducto))
                {
                    Cliente.BaseAddress = new Uri(DirBase);
                    Cliente.DefaultRequestHeaders.Accept.Clear();
                    Cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/Json"));

                    HttpResponseMessage respuesta = await Cliente.GetAsync($"{SolicitudClienteURI}");
                    respuesta.EnsureSuccessStatusCode();

                    if (respuesta.IsSuccessStatusCode)
                    {
                        var jsoncadena = await respuesta.Content.ReadAsStringAsync();
                        Producto = JsonConvert.DeserializeObject<Products>(jsoncadena);
                    }
                    else
                    {
                        Error = "Se ha producido un error al olicitar el servivio web";
                        throw new Exception();
                    }
                }
            }
            catch (HttpRequestException ex) { 
                Error = ex.Message;
            }
        }
        List<DataProductos_> ListProductos = new List<DataProductos_>();

        public List<DataProductos_> GenerarListaProductos()
        {
            for (int n = 0; n < 40; n++)
            {
                DataProductos_ Dp = new DataProductos_
                {
                    ProductID = Producto.ProductosDatos[n].ProductID,
                    ProductName = Producto.ProductosDatos[n].ProductName,
                    SupplierID = Producto.ProductosDatos[n].SupplierID,
                    CategoryID = Producto.ProductosDatos[n].CategoryID,
                    QuantityPerUnit = Producto.ProductosDatos[n].QuantityPerUnit,
                    UnitPrice = Producto.ProductosDatos[n].UnitPrice,
                    UnitsInStock = Producto.ProductosDatos[n].UnitsInStock,
                    UnitsOnOrder = Producto.ProductosDatos[n].UnitsInStock,
                    ReorderLevel = Producto.ProductosDatos[n].ReorderLevel,
                    Discontinued = Producto.ProductosDatos[n].Discontinued
                };
                ListProductos.Add(Dp);
            }
            return (ListProductos);
        }

        

    }
}