using System;

namespace ClassLibrary
{
    public class clsJob
    {
       
        public int jobID { get; set; }
        public string lastName { get; set; }
        public string houseName { get; set; }
        public string comments { get; set; }
        public DateTime date { get; set; }
        public double jobTake { get; set; }
        public int totalVisits { get; set; }
    }
}