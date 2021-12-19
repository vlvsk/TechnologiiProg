using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class ClientStorage
    {
        private readonly Dictionary<int, Client> _clients = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public Client Create(Client client)
        {
            var clientId = _clients.Keys.Max() + 1;
            client.Id = clientId;
            _clients.Add(client.Id, client);
            return client;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Client Read(int clientId)
        {
            return _clients[clientId];
        }

        public Client Update(int clientId, Client newClient)
        {
            _clients[clientId] = newClient;
            return _clients[clientId];
        }

        public bool Delete(int clientId)
        {
            return _clients.Remove(clientId);
        }
    }
}