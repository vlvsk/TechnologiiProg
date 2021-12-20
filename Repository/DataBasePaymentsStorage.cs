using TechnologiiProg.Domain;
using System.Collections.Generic;
using System.Linq;

namespace TechnologiiProg.Repository
{
    public class DataBasePaymentsStorage
    {
        private readonly Dictionary<int, DataBasePayments> _dataPays = new ();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CustomerStorage() => Connection.Open();

        public void Create(DataBasePayments dataPay)
        {

            _dataPays.Add(dataPay.Id, dataPay);

            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public DataBasePayments Read(int dataPayId)
        {
            return _dataPays[dataPayId];
        }

        public DataBasePayments Update(int dataPayId, DataBasePayments newDataPay)
        {
            _dataPays[dataPayId] = newDataPay;
            return _dataPays[dataPayId];
        }

        public bool Delete(int dataPayId)
        {
            return _dataPays.Remove(dataPayId);
        }
    }
}