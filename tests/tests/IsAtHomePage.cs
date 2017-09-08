using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeBank;

namespace tests
{
    [TestClass]
    public class IsAtHomePage
    {
        [TestMethod]
        public void CanGoToHomePage()
        {
            HomePage homepage = new HomePage();
            homepage.GoTo();
            Assert.IsTrue(homepage.IsAt());
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }
    }
}
