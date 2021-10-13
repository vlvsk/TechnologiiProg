using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TechnologiiProg.Controllers
{
    [ApiController]
    [Route("/Registratyra")]
    public class RegistratyraController : ControllerBase
    {

        [HttpGet("PriemZapis")]
        public string PriemZapis(string str)
        {
            return str; //"Метод приема записи"
        }

        [HttpGet("PriemOplata")]
        public string PriemOplata(string str)
        {
            return str;// "Метод приема оплаты"
        }


        [HttpGet("PodgotovkaDocuments")]
        public string PodgotovkaDocuments(string str)
        {
            return str;// "Метод подготовки документов"
        }
    }
}