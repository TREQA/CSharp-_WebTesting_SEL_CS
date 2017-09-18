using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBank
{
    public class HomePage
    {
        string Url = "https://www.homebank.ro";
        private string pageTitle = "ING Home'Bank - Login";
        private string loginButtonCssSelector = "div.submitLogin > input";
        private string error1ID = "errorDiv1";
        private string error2ID = "errorDiv";
        private string passwordID = "password";
        private string usernameID = "username";

        Browser browser = new Browser();

        public void GoTo()
        {
            browser.GoTo(Url);
            browser.MaximizeWindow();
        }

        public bool IsAt()
        {
            return browser.Title == pageTitle;
        }

        public void UserInput(string user)
        {
            browser.Input(usernameID, user);
        }

        public void PasswordInput(string password)
        {
            browser.Input(passwordID, password);
        }

        public void Login()
        {
            browser.Click(loginButtonCssSelector);
        }

        public string ErrorCheck1()
        {
            return browser.ErrorCheck(error1ID);
        }

        public string ErrorCheck2()
        {
            string first = new StringReader(browser.ErrorCheck(error2ID)).ReadLine();
            return first;
        }

        public void Close()
        {
            browser.Close();
        }
    }
}
