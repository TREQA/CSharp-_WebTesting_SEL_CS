using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeBank
{
    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver();

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        public static void UserInput(string user)
        {
            IWebElement username = webDriver.FindElement(By.Id("username"));
            username.SendKeys(user);
        }

        public static void PasswordInput(string password)
        {
            IWebElement pass = webDriver.FindElement(By.Id("password"));
            pass.SendKeys(password);
            pass.Submit();
        }

        public static string ErrorCheck()
        {
            string loginerror = webDriver.FindElement(By.Id("errorDiv1")).Text;
            return loginerror;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
