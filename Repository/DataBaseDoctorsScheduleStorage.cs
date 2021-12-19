using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class DataBaseDoctorsScheduleStorage
    {
        private readonly Dictionary<int, DataBaseDoctorsSchedule> _dataSchedules = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public DataBaseDoctorsSchedule Create(DataBaseDoctorsSchedule dataSchedule)
        {
            var dataScheduleId = _dataSchedules.Keys.Max() + 1;
            dataSchedule.Id = dataScheduleId;
            _dataSchedules.Add(dataSchedule.Id, dataSchedule);
            return dataSchedule;
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