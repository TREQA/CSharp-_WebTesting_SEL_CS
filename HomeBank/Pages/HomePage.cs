using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeBank
{
    public class HomePage
    {
        private IWebDriver webDriver = new ChromeDriver();

        internal string Url = "https://www.homebank.ro";
        internal string pageTitle = "ING Home'Bank - Login";
        internal string loginButtonCssSelector = "div.submitLogin > input";
        internal string error1ID = "errorDiv1";
        internal string error2ID = "errorDiv";
        internal string passwordID = "password";
        internal string usernameID = "username";

        public void GoTo()
        {
            webDriver.Url = Url;
            webDriver.Manage().Window.Maximize();
        }

        public bool IsAt()
        {
            return webDriver.Title == pageTitle;
        }

        public void UserInput(string user)
        {
            IWebElement element = webDriver.FindElement(By.Id(usernameID));
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.SendKeys(user);
        }

        public void PasswordInput(string password)
        {
            IWebElement element = webDriver.FindElement(By.Id(passwordID));
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.SendKeys(password);
        }

        public void Login()
        {
            IWebElement element = webDriver.FindElement(By.CssSelector(loginButtonCssSelector));
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.Click();
        }

        public string ErrorCheck1()
        {
            return webDriver.FindElement(By.Id(error1ID)).Text;
        }

        public string ErrorCheck2()
        {
            string first = new StringReader(webDriver.FindElement(By.Id(error2ID)).Text).ReadLine();
            return first;
        } 

        public void Close()
        {
            webDriver.Dispose();
        }
    }
}