using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class RegistryStorage
    {
        private readonly Dictionary<int, Registry> _registrys = new ();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(Registry registry)
        {

            _registrys.Add(registry.Id, registry);

            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Registry Read(int registryId)
        {
            return _registrys[registryId];
        }

        public Registry Update(int registryId, Registry newRegistry)
        {
            _registrys[registryId] = newRegistry;
            return _registrys[registryId];
        }

        public bool Delete(int registryId)
        {
            return _registrys.Remove(registryId);
        }
    }
}