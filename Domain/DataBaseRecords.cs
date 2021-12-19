using System;
namespace TechnologiiProg.Domain
{
    public class DataBaseRecords
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Client { get; set; }
        public int Doctor { get; set; }
        public int Registry { get; set; }
        public string Refusal { get; set; }

    }
}