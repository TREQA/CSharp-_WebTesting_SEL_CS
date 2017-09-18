using System;
using TechTalk.SpecFlow;
using HomeBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [Binding]
    public class IngHomeBankFeatureSteps
    {
        HomePage homepage = new HomePage();

        [Given(@"I am on the homepage of the site")]
        public void GivenIAmOnTheHomepageOfTheSite()
        {
            homepage.GoTo();
        }

        [Given(@"I enter a username of (.*)")]
        public void GivenIEnterAUsernameOf(string username)
        {
            homepage.UserInput(username);
        }

        [Given(@"I enter a password of (.*)")]
        public void GivenIEnterAPasswordOf(string password)
        {
            homepage.PasswordInput(password);
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            homepage.Login();
        }

        [Then(@"I should see an error message telling me that the username and/or password are incorrect")]
        public void ThenIShouldSeeAnErrorMessageTellingMeThatTheUsernameAndOrPasswordAreIncorrect()
        {
            Assert.AreEqual("Codul de Utilizator/Codul introduse nu sunt corecte!", homepage.ErrorCheck1());
        }

        [Then(@"I should see an error message telling me that i need fill both username and password fields with values")]
        public void ThenIShouldSeeAnErrorMessageTellingMeThatINeedFillBothUsernameAndPasswordFieldsWithValues()
        {
            Assert.AreEqual("Codul de Utilizator şi Codul sunt obligatorii.", homepage.ErrorCheck2());
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            homepage.Close();
        }
    }
}
