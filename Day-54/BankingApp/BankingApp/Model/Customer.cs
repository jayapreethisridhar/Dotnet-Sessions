namespace BankingApp.Model
{
    public class Customer
    {
        public string _name { get; set; } = "";
        public string _email { get; set; } = "";
        public string _iD { get; set; }
        public double _balance { get; set; }

        public decimal _password { get; set; }
    }
}
