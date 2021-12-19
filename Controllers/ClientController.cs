using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechnologiiProg.Domain;
using TechnologiiProg.Repository;

namespace TechnologiiProg.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {

        [HttpGet("Recording")]
        public string Recording(string str)
        {
            return str; //"Метод записи"
        }

        [HttpGet("Payment")]
        public string Payment(string str)
        {
            return str;// "Метод оплаты"
        }


        [HttpGet("DocumentsCL")]
        public string DocumentsCL(string str)
        {
            return str;// "Метод передачи документов"
        }

        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return Storage.ClientStorage.Read(client.Id);
        }

        [HttpGet]
        public Client Read(int Id)
        {
            return Storage.ClientStorage.Read(Id);
        }

        [HttpPatch]
        public Client Update(int Id, Client newClient)
        {
            return Storage.ClientStorage.Update(Id, newClient);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.ClientStorage.Delete(Id);
        }
    }
}