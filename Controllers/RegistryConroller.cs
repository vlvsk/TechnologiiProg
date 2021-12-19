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
    [Route("/registry")]
    public class RegistryController : ControllerBase
    {

        [HttpGet("ReceiveRecording")]
        public string ReceiveRecording(string str)
        {
            return str; //"Метод приема записи"
        }

        [HttpGet("AcceptPayment")]
        public string AcceptPayment(string str)
        {
            return str;// "Метод приема оплаты"
        }


        [HttpGet("ViewDocuments")]
        public string ViewDocuments(string str)
        {
            return str;// "Метод просмотра документов"
        }

        [HttpGet("PreparationDocuments")]
        public string PreparationDocuments(string str)
        {
            return str;// "Метод подготовки документов"
        }

        [HttpGet("Scheduling")]
        public string Scheduling(string str)
        {
            return str;// "Метод формирования расписания"
        }

        [HttpPut]
        public Registry Create(Registry registry)
        {
            Storage.RegistryStorage.Create(registry);
            return Storage.RegistryStorage.Read(registry.Id);
        }

        [HttpGet]
        public Registry Read(int Id)
        {
            return Storage.RegistryStorage.Read(Id);
        }

        [HttpPatch]
        public Registry Update(int Id, Registry newRegistry)
        {
            return Storage.RegistryStorage.Update(Id, newRegistry);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.RegistryStorage.Delete(Id);
        }
    }
}