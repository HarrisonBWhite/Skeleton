using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6Requests
{
    [TestClass]
    public class tstRequests
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRequests AnRequests = new clsRequests();
            Assert.IsNotNull(AnRequests);
        }
    }
}
