using System;

namespace ClassLibrary
{
    public class clsFinance
    {
        public clsFinance()
        {
        }

        public bool Active { get; set; }
        public int financeID { get; set; }
        public DateTime date { get; set; }
        public double jobTake { get; set; }
    }
}