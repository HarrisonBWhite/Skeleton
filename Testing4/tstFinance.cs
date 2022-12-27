using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4Finance
{
    [TestClass]
    public class tstFinance
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsFinance AnFinance = new clsFinance();
            Assert.IsNotNull(AnFinance);
        }
    }
}
