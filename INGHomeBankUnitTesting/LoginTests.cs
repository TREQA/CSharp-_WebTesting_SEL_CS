using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace INGHomeBankUnitTesting
{
    class LoginTests
    {
        [TestClass]
        public class LoginTests1
        {
            [TestMethod]
            public void Test1()
            {
                IWebElement username = Username(driver);
                IWebElement password = Password(driver);
                IWebElement error = Error(driver);
                searchBox.SendKeys("test");
                searchBox.SendKeys("test");
                searchBox.Submit();
            }
        }
    }
}
