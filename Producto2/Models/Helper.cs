using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

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
                    ProductID = Producto.Productos[n].ProductID,
                    ProductName = Producto.Productos[n].ProductName,
                    SupplierID = Producto.Productos[n].SupplierID,
                    CategoryID = Producto.Productos[n].CategoryID,
                    QuantityPerUnit = Producto.Productos[n].QuantityPerUnit,
                    UnitPrice = Producto.Productos[n].UnitPrice,
                    UnitsInStock = Producto.Productos[n].UnitsInStock,
                    UnitsOnOrder = Producto.Productos[n].UnitsInStock,
                    ReorderLevel = Producto.Productos[n].ReorderLevel,
                    Discontinued = Producto.Productos[n].Discontinued
                };
                ListProductos.Add(Dp);
            }
            return (ListProductos);
        }
        //Unidades en stock DataList(Enlace cuarto)
        public int DropStock { get; set; }
        public List<DataProductos_> ProductosStock()
        { 
            for (int n = 0;n <= Producto.Productos.Length - 1;n++) {
                if (Producto.Productos[n].UnitsInStock >= DropStock)
                {
                    DataProductos_ Pr = new DataProductos_
                    {
                        ProductID = Producto.Productos[n].ProductID,
                        ProductName = Producto.Productos[n].ProductName,
                        CategoryID = Producto.Productos[n].CategoryID,
                        UnitPrice = Producto.Productos[n].UnitPrice
                    };
                    ListProductos.Add( Pr );
                }
            }
            return ListProductos;
        }

        //Buscar por precio
        public int PrecioN { get;set; }
        public int PrecioD { get; set; }

        public List<DataProductos_> PrecioProductos()
        {
            for (int n = 0; n <= Producto.Productos.Length -1;n++) { 
                if ((Producto.Productos[n].UnitPrice >= PrecioN) && (Producto.Productos[n].UnitPrice <= PrecioD) ) {
                    DataProductos_ Pr = new DataProductos_
                    {
                        ProductID = Producto.Productos[n].ProductID,
                        CategoryID = Producto.Productos[n].CategoryID,
                        ProductName = Producto.Productos[n].ProductName,
                        UnitPrice = Producto.Productos[n].UnitPrice,
                        UnitsInStock = Producto.Productos[n].UnitsInStock
                    };
                    ListProductos.Add( Pr );
                }

            }
            return ListProductos;
        }

        //Buscar por categoría
        public int DropCat {get; set;}
        public List<DataProductos_> ProdsCategoria()
        {
            for (int n = 0; n <= Producto.Productos.Length -1 ; n++)
            {
                if (Producto.Productos[n].CategoryID == DropCat)
                {
                    DataProductos_ Pr = new DataProductos_
                    {
                        ProductID = Producto.Productos[n].ProductID ,
                        CategoryID = Producto.Productos[n].CategoryID,
                        ProductName = Producto.Productos[n].ProductName,
                        QuantityPerUnit = Producto.Productos[n].QuantityPerUnit,
                        UnitPrice = Producto.Productos[n].UnitPrice
                    };
                ListProductos.Add( Pr );
                }
            }
            return ListProductos;
        }

        ClienteP Clientes;
        //Aquí inician LAS FUNCIONES PARA EL USO DEL ENDPOINT PARA PAISES
        public async Task ObtenerDatosClientesAsync()
        {
            DirBase = "https://run.mocky.io";
            string SolicitudClienteURI = "v3/8865f9d9-7b40-4caf-a1c0-bed415440115";

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
                        Clientes = JsonConvert.DeserializeObject<ClienteP>(jsoncadena);
                    }
                    else
                    {
                        Error = "Se ha producido un error al olicitar el servivio web";
                        throw new Exception();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Error = ex.Message;
            }
        }

        public string DropPais { get; set; }
        
        List<DataClient> ListClient = new List<DataClient>();

        public List<DataClient> InfoClient()
        {
            for (int i = 0;i <= Clientes.Clientes.Length -1; i++)
            {
                if (Clientes.Clientes[i].Country == DropPais)
                {
                    DataClient Pr = new DataClient()
                    {
                        CustomerID = Clientes.Clientes[i].CustomerID,
                        CompanyName = Clientes.Clientes[i].CompanyName,
                        Address = Clientes.Clientes[i].Address,
                        City = Clientes.Clientes[i].City,
                        Phone = Clientes.Clientes[i].Phone,
                        Fax = Clientes.Clientes[i].Fax
                    };
                    ListClient.Add(Pr);
                }
            }
            return ListClient;
        }

    }
}