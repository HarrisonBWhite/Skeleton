namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get; set; }
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string houseName { get; set; }
        public string street { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string postcode { get; set; }
        public string contactNumber { get; set; }
        public string email { get; set; }
        public int totalChimneys { get; set; }
        public string comments { get; set; }
        public int totalVisits { get; set; }
    }
}