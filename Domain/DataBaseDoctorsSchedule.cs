using System;

namespace TechnologiiProg.Domain
{
    public class DataBaseDoctorsSchedule
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Doctor { get; set; }
        public int Registry { get; set; }

    }
}