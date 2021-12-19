using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class DataBaseDocumentsStorage
    {
        private readonly Dictionary<int, DataBaseDocuments> _dataDocs = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public DataBaseDocuments Create(DataBaseDocuments dataDoc)
        {
            var dataDocId = _dataDocs.Keys.Max() + 1;
            dataDoc.Id = dataDocId;
            _dataDocs.Add(dataDoc.Id, dataDoc);
            return dataDoc;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DataBaseDocuments Read(int dataDocId)
        {
            return _dataDocs[dataDocId];
        }

        public DataBaseDocuments Update(int dataDocId, DataBaseDocuments newDataDoc)
        {
            _dataDocs[dataDocId] = newDataDoc;
            return _dataDocs[dataDocId];
        }

        public bool Delete(int dataDocId)
        {
            return _dataDocs.Remove(dataDocId);
        }
    }
}