using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAEAPP.API;
using ESAEAPP.Models;
using Newtonsoft.Json;

namespace ESAEAPP.Controller
{
    class CursoApiController
    {
        private WS servidor; //ligação ao servidor
        public List<Curso> ListaCursos;

        public CursoApiController()
        {
            servidor = new WS();

            ListaCursos = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://192.168.1.99/ismtp3/public/api/cursos").ReadLine());
        }
    }
}
