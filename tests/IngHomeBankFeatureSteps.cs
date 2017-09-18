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
        
        [Given(@"I enter a username of ""(.*)""")]
        public void GivenIEnterAUsernameOf(string username)
        {
            homepage.UserInput("Test");
        }

        [Given(@"I enter a password of ""(.*)""")]
        public void GivenIEnterAPasswordOf(string password)
        {
            homepage.PasswordInput("Test");
        }
        
        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            homepage.Login();
        }
        
        [Then(@"I should see the ""(.*)"" error")]
        public void ThenIShouldSeeTheError(string p0)
        {
            Assert.AreEqual("Codul de Utilizator/Codul introduse nu sunt corecte!", homepage.ErrorCheck());
        }
    }
}
