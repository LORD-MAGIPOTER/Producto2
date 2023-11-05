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
        Productos Productos;
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
                        Productos = JsonConvert.DeserializeObject<Productos>(jsoncadena);
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
        public int productoID() {
            return Productos.productoid;
        }
        public string name()
        {
            return Productos.name;
        }
        public int supplier()
        {
            return Productos.supplier;
        }
        public int categoryid()
        {
            return Productos.categoryID;
        }
        public string quantityUnit()
        {
            return Productos.quantityUnit;
        }
        public int unitPrice()
        {
            return Productos.unitPrice;
        }
        public int unitStore()
        {
            return Productos.unitStore;
        }
        public int unitOrder()
        {
            return Productos.unitOrder;
        }
        public int RecorderLevel()
        {
            return Productos.RecorderLevel;
        }
        public int discontinued()
        {
            return Productos.discontinued;
        }

    }
}