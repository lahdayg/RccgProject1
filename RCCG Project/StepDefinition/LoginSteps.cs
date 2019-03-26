using System;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;
using RCCG_Project.PageObjects;
using RCCG_Project.Utilities;
using TechTalk.SpecFlow;

namespace RCCG_Project.StepDefinition
{
    [Binding]
    public class LoginSteps

    {
        LoginClass1 loginclass1;

        public LoginSteps()
        {
            loginclass1 = new LoginClass1();
        }
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I when i click login")]
        public void WhenIWhenIClickLogin()
        {
            loginclass1.ClickLogin();
        }

        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            loginclass1.TypeEmail();
        }

        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            loginclass1.TypePassword();
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginclass1.ClickSignin();
        }

        [Then(@"I am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(loginclass1.IslogoutMsgDisplayed(), "Error Message:Login Failed");

            loginclass1.IslogoutMsgDisplayed().Should().BeTrue("Error Message: Registration failed");
        }





        //[Then(@"I should be logged in")]
        //public void ThenIShouldBeLoggedIn()
        
            // verify that you are logged in
            // PageObject - create an element
            // pageobject - create a method to confirm if the element is visible
            // on the step definition - You call the method

           // loginclass1.IsloginErrorMsgDisplayed();
        }
    }

