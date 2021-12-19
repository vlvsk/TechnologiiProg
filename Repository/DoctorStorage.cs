using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class DoctorStorage
    {
        private readonly Dictionary<int, Doctor> _doctors = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public Doctor Create(Doctor doctor)
        {
            var doctorId = _doctors.Keys.Max() + 1;
            doctor.Id = doctorId;
            _doctors.Add(doctor.Id, doctor);
            return doctor;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Doctor Read(int doctorId)
        {
            return _doctors[doctorId];
        }

        public Doctor Update(int doctorId, Doctor newDoctor)
        {
            _doctors[doctorId] = newDoctor;
            return _doctors[doctorId];
        }

        public bool Delete(int doctorId)
        {
            return _doctors.Remove(doctorId);
        }
    }
}