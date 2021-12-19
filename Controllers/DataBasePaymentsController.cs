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
    [Route("/dataBasePayments")]
    public class DataBasePaymentsController : ControllerBase
    {

        [HttpPut("Create")]
        public DataBasePayments Create(DataBasePayments dataPay)
        {
            Storage.DataBasePaymentsStorage.Create(dataPay);
            return Storage.DataBasePaymentsStorage.Read(dataPay.Id);
        }

        [HttpGet("Read")]
        public DataBasePayments Read(int Id)
        {
            return Storage.DataBasePaymentsStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public DataBasePayments Update(int Id, DataBasePayments newDataPay)
        {
            return Storage.DataBasePaymentsStorage.Update(Id, newDataPay);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.DataBasePaymentsStorage.Delete(Id);
        }
    }
}