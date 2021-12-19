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
    [Route("/dataBaseDocuments")]
    public class DataBaseDocumentsController : ControllerBase
    {

        [HttpPut("Create")]
        public DataBaseDocuments Create(DataBaseDocuments dataDoc)
        {
            Storage.DataBaseDocumentsStorage.Create(dataDoc);
            return Storage.DataBaseDocumentsStorage.Read(dataDoc.Id);
        }

        [HttpGet("Read")]
        public DataBaseDocuments Read(int Id)
        {
            return Storage.DataBaseDocumentsStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public DataBaseDocuments Update(int Id, DataBaseDocuments newDataDoc)
        {
            return Storage.DataBaseDocumentsStorage.Update(Id, newDataDoc);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.DataBaseDocumentsStorage.Delete(Id);
        }
    }
}