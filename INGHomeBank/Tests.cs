using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INGHomeBank
{
    public class Tests
    {
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.homebank.ro/public/HomeBankLogin/home";

            IWebElement username = Username(driver);
            username.SendKeys("test");
            IWebElement password = Password(driver);
            password.SendKeys("test");

            password.Submit();
            string error = Error(driver);
            Assert.AreEqual("Codul de Utilizator/Codul introduse nu sunt corecte!", error);

        }

        public static IWebElement Username(IWebDriver driver)
        {
            return driver.FindElement(By.Id("username"));
        }

        public static IWebElement Password(IWebDriver driver)
        {
            return driver.FindElement(By.Id("password"));
        }      

        public static string Error(IWebDriver driver)
        {
            string error = driver.FindElement(By.Id("errorDiv1")).Text;
            return error;
        }
    }
}
