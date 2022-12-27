using System;

namespace ClassLibrary
{
    public class clsAlert
    {
        public bool Active { get; set; }
        public int alertID { get; set; }
        public int customerID { get; set; }
        public DateTime date { get; set; }
        public int reminderInterval { get; set; }
    }
}