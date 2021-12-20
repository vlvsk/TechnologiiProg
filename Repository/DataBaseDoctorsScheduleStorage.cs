using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class DataBaseDoctorsScheduleStorage
    {
        private readonly Dictionary<int, DataBaseDoctorsSchedule> _dataSchedules  = new ();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(DataBaseDoctorsSchedule dataSchedule)
        {
            
            _dataSchedules.Add(dataSchedule.Id, dataSchedule);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DataBaseDoctorsSchedule Read(int dataScheduleId)
        {
            return _dataSchedules[dataScheduleId];
        }

        public DataBaseDoctorsSchedule Update(int dataScheduleId, DataBaseDoctorsSchedule newDataSchedule)
        {
            _dataSchedules[dataScheduleId] = newDataSchedule;
            return _dataSchedules[dataScheduleId];
        }

        public bool Delete(int dataScheduleId)
        {
            return _dataSchedules.Remove(dataScheduleId);
        }
    }
}