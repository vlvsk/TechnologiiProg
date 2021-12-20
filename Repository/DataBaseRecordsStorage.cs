using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class DataBaseRecordsStorage
    {
        private Dictionary<int, DataBaseRecords> _dataRecs= new ();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(DataBaseRecords dataRec)
        {

            _dataRecs.Add(dataRec.Id, dataRec);
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