using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class DataBaseRecordsStorage
    {
        private readonly Dictionary<int, DataBaseRecords> _dataRecs = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public DataBaseRecords Create(DataBaseRecords dataRec)
        {
            var dataRecId = _dataRecs.Keys.Max() + 1;
            dataRec.Id = dataRecId;
            _dataRecs.Add(dataRec.Id, dataRec);
            return dataRec;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DataBaseRecords Read(int dataRecId)
        {
            return _dataRecs[dataRecId];
        }

        public DataBaseRecords Update(int dataRecId, DataBaseRecords newDataRec)
        {
            _dataRecs[dataRecId] = newDataRec;
            return _dataRecs[dataRecId];
        }

        public bool Delete(int dataRecId)
        {
            return _dataRecs.Remove(dataRecId);
        }
    }
}