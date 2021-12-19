namespace TechnologiiProg.Domain
{
    public class DataBasePayments
    {
        public int Id { get; set; }
        public decimal MoneyTransfer { get; set; }
        public int Client { get; set; }
        public int Registry { get; set; }

    }
}