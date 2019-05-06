using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace GestorLogistica
{

    [WebService(Namespace = "http://gestorlogistica.cetraro.uai/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Proveedor[] ProveedoresXML()
        {
            Proveedor[] provs = new Proveedor[] {
            new Proveedor(675,"HK6N1M0", 23, "PyG", 478.25){},
            new Proveedor(243,"A234MKL1", 113, "Kraft Foods", 986.51){}
        };
            return provs;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string ProveedoresJSON()
        {
            Proveedor[] provs = new Proveedor[] {
            new Proveedor(675,"HK6N1M0", 23, "PyG", 478.25){},
            new Proveedor(243,"A234MKL1", 113, "Kraft Foods", 986.51){}
        };
            return new JavaScriptSerializer().Serialize(provs);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string PedidosJSON()
        {
            TotalPedido[] total = new TotalPedido[] {
            new TotalPedido("Logistica del Sur",8503.20,"Cordoba 451, Capial Federal"){},
            new TotalPedido("Rapi Envios",10600.50, "San Martin 8, Neuquen"){}
        };
            return new JavaScriptSerializer().Serialize(total);
        }

        [WebMethod]
        public Contratista[] ContratistasXML()
        {
            Contratista[] contra = new Contratista[] {
            new Contratista("Logistica del Sur","Don Torcuato","63-54125036-8"){},
            new Contratista("Envios Express","Capital Federal","63-20563108-3"){},
            new Contratista("Super Cargo","San Martin","63-96412570-7"){},
            new Contratista("Rapi Envios","San Nicolas","63-15230687-6"){},
            };
            return contra;
        }

    }
}
