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
    class EventoApiController
    {
        private WS servidor; //ligação ao servidor
        public List<Evento> ListaEventos;

        public EventoApiController()
        {
            servidor = new WS();

            ListaEventos = JsonConvert.DeserializeObject<List<Evento>>(servidor.PedidoServidor("http://192.168.1.99/ismtp3/public/api/eventos").ReadLine());
        }
    }
}
