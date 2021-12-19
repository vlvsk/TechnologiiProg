using System;

namespace TechnologiiProg.Domain
{
    public class Registry
    {
        public int Id { get; set; }
        public int Client { get; set; }
        public int Doctor { get; set; }
        public DateTime DateTime { get; set; }
        public int DoctorShedule { get; set; }
    }
}