using ESAEAPP.API;
using ESAEAPP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAEAPP.Controller
{
    class AvisoApiController
    {
        private WS servidor; //ligação ao servidor
        public List<Aviso> ListaAvisos;

        public AvisoApiController()
        {
            servidor = new WS();

            ListaAvisos = JsonConvert.DeserializeObject<List<Aviso>>(servidor.PedidoServidor("http://192.168.1.99/ismtp3/public/api/avisos").ReadLine());
        }
    }
}
