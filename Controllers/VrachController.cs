using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TechnologiiProg.Controllers
{
    [ApiController]
    [Route("/Vrach")]
    public class VrachController : ControllerBase
    {

        [HttpGet("ProsmotrRaspis")]
        public string ProsmotrRaspis(string str)
        {
            return str; //"Метод просмотра расписания"
        }

        [HttpGet("OnlinePriem")]
        public string OnlinePriem(string str)
        {
            return str;// "Метод онлайн приема"
        }


        [HttpGet("PodgotovkaZaklychenia")]
        public string PodgotovkaZaklychenia(string str)
        {
            return str;// "Метод подготовки заключения"
        }
    }
}