using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1Login
{
    [TestClass]
    public class tstLogin
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLogin AnLogin = new clsLogin();
            Assert.IsNotNull(AnLogin);
        }
    }
}
