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
    [Route("/doctor")]
    public class DoctorController : ControllerBase
    {

        [HttpGet("ViewSchedule")]
        public string ViewSchedule(string str)
        {
            return str; //"Метод просмотра расписания"
        }

        [HttpGet("OnlineReception")]
        public string OnlineReception(string str)
        {
            return str;// "Метод онлайн приема"
        }


        [HttpGet("PreparationConclusion")]
        public string PreparationConslusion(string str)
        {
            return str;// "Метод подготовки заключения"
        }

        [HttpPut]
        public Doctor Create(Doctor doctor)
        {
            Storage.DoctorStorage.Create(doctor);
            return Storage.DoctorStorage.Read(doctor.Id);
        }

        [HttpGet]
        public Doctor Read(int Id)
        {
            return Storage.DoctorStorage.Read(Id);
        }

        [HttpPatch]
        public Doctor Update(int Id, Doctor newDoctor)
        {
            return Storage.DoctorStorage.Update(Id, newDoctor);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.DoctorStorage.Delete(Id);
        }
    }
}