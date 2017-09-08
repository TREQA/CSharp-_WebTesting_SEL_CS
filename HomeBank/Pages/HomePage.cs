using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBank
{
    public class HomePage
    {
        string Url = "https://www.homebank.ro";
        private string PageTitle = "ING Home'Bank - Login";

        public void GoTo()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void UserInput(string user)
        {
            Browser.UserInput(user);
        }

        public void PasswordInput(string password)
        {
            Browser.PasswordInput(password);
        }

        public string ErrorCheck()
        {
            return Browser.ErrorCheck();
        }

        
    }
}
