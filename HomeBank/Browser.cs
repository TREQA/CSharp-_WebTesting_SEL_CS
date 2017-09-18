using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeBank
{
    internal class Browser
    {
        private IWebDriver webDriver = new ChromeDriver();

        internal string Title
        {
            get { return webDriver.Title; }
        }

        internal void GoTo(string url)
        {
            webDriver.Url = url;
        }

        internal void Input(string location, string input)
        {
            IWebElement element = webDriver.FindElement(By.Id(location));
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.SendKeys(input);
        }

        internal void Click(string location)
        {
            IWebElement element = webDriver.FindElement(By.CssSelector(location));
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            element.Click();
        }

        internal string ErrorCheck(string location)
        {
            string loginerror = webDriver.FindElement(By.Id(location)).Text;
            return loginerror;
        }

        internal void MaximizeWindow()
        {
            webDriver.Manage().Window.Maximize();
        }

        internal void Close()
        {
            webDriver.Dispose();
        }
    }
}
