using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace INGHomeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.homebank.ro/public/HomeBankLogin/home";
        }
    }
}
