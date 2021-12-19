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
    [Route("/typesRecords")]
    public class TypesRecordsController : ControllerBase
    {
        [HttpPut("Create")]
        public TypesRecords Create(TypesRecords typesRec)
        {
            Storage.TypesRecordsStorage.Create(typesRec);
            return Storage.TypesRecordsStorage.Read(typesRec.Id);
        }

        [HttpGet("Read")]
        public TypesRecords Read(int Id)
        {
            return Storage.TypesRecordsStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public TypesRecords Update(int Id, TypesRecords newTypesRec)
        {
            return Storage.TypesRecordsStorage.Update(Id, newTypesRec);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.TypesRecordsStorage.Delete(Id);
        }

    }
}