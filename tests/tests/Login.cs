using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeBank;

namespace tests
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginCheck()
        {
            HomePage homepage = new HomePage();
            homepage.GoTo();
            homepage.UserInput("test");
            homepage.PasswordInput("test");
            Assert.AreEqual("Codul de Utilizator / Codul introduse nu sunt corecte!", homepage.ErrorCheck());
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }        
    }
}

