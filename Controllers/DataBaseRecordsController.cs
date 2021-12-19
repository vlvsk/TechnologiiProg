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
    [Route("/dataBaseRecords")]
    public class DataBaseRecordsController : ControllerBase
    {
        [HttpPut("Create")]
        public DataBaseRecords Create(DataBaseRecords dataRec)
        {
            Storage.DataBaseRecordsStorage.Create(dataRec);
            return Storage.DataBaseRecordsStorage.Read(dataRec.Id);
        }

        [HttpGet("Read")]
        public DataBaseRecords Read(int Id)
        {
            return Storage.DataBaseRecordsStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public DataBaseRecords Update(int Id, DataBaseRecords newDataRec)
        {
            return Storage.DataBaseRecordsStorage.Update(Id, newDataRec);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.DataBaseRecordsStorage.Delete(Id);
        }

    }
}