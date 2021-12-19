using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class TypesRecordsStorage
    {
        private readonly Dictionary<int, TypesRecords> _typesRecs = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public TypesRecords Create(TypesRecords typesRec)
        {
            var typesRecId = _typesRecs.Keys.Max() + 1;
            typesRec.Id = typesRecId;
            _typesRecs.Add(typesRec.Id, typesRec);
            return typesRec;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public TypesRecords Read(int typesRecId)
        {
            return _typesRecs[typesRecId];
        }

        public TypesRecords Update(int typesRecId, TypesRecords newTypesRec)
        {
            _typesRecs[typesRecId] = newTypesRec;
            return _typesRecs[typesRecId];
        }

        public bool Delete(int typesRecId)
        {
            return _typesRecs.Remove(typesRecId);
        }
    }
}