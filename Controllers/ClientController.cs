using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TechnologiiProg.Controllers
{
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {

        [HttpGet("Zapis")]
        public string Zapis(string str)
        {
            return str; //"Метод записи"
        }

        [HttpGet("Oplata")]
        public string Oplata(string str)
        {
            return str;// "Метод оплаты"
        }


        [HttpGet("DocumentsCL")]
        public string DocumentsCL(string str)
        {
            return str;// "Метод передачи документов"
        }
    }
}