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
    [Route("/dataBaseDoctorsSchedule")]
    public class DataBaseDoctordScheduleController : ControllerBase
    {

        [HttpPut("Create")]
        public DataBaseDoctorsSchedule Create(DataBaseDoctorsSchedule dataSchedule)
        {
            Storage.DataBaseDoctorsScheduleStorage.Create(dataSchedule);
            return Storage.DataBaseDoctorsScheduleStorage.Read(dataSchedule.Id);
        }

        [HttpGet("Read")]
        public DataBaseDoctorsSchedule Read(int Id)
        {
            return Storage.DataBaseDoctorsScheduleStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public DataBaseDoctorsSchedule Update(int Id, DataBaseDoctorsSchedule newDataSchedule)
        {
            return Storage.DataBaseDoctorsScheduleStorage.Update(Id, newDataSchedule);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.DataBaseDoctorsScheduleStorage.Delete(Id);
        }
    }
}