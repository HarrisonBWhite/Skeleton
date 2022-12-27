using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3CompletedJob
{
    [TestClass]
    public class tstCompletedJob
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCompletedJob AnCompletedJob = new clsCompletedJob();
            Assert.IsNotNull(AnCompletedJob);
        }
    }
}
