using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5Alert
{
    [TestClass]
    public class tstAlert
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAlert AnAlert = new clsAlert();
            Assert.IsNotNull(AnAlert);
        }
    }
}
