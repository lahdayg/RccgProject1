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
    public class RegistrationSteps
    {

        Registration_Page registration;

        public RegistrationSteps()
        {
            registration = new Registration_Page(); 
        }


        [Given(@"I navigate to site")]
        public void GivenINavigateToSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }

        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registration.EnterLastName();
        }


        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }


        
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNumber();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.TypePassword();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterPassword();
        }
        
        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
            registration.ClickSignUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {

            Thread.Sleep(5000);
            Assert.IsTrue(registration.SuccessMessageIsDisplayed(), "Error Message: Registration failed");

            registration.SuccessMessageIsDisplayed().Should().BeTrue("Error Message: Registration failed");



        }
         [When(@"I enter password ""(.*)""")]
         public void WhenIEnterPassword(string passwordEntered)
         {
             registration.EnterPassword();
         }

         [When(@"I confirm password ""(.*)""")]
         public void WhenIConfirmPassword(string confirmPasswordEntered)
         {
             registration.EnterPassword();
         }
         
       


        
        
        [Then(@"the password is too short error is displayed")]
        public void ThenThePasswordIsTooShortErrorIsDisplayed()
        {
            registration.PasswordTooShortMessageIsDisplayed().Should().BeTrue("Password is not too short");
        }


        [Then(@"the error message ""(.*)""is displayed for ""(.*)""")]
        public void ThenTheErrorMessageIsDisplayedFor(string message, string field)
        {
          //  if (test == "PasswordTooShort")
            registration.GetTextForPasswordTooShort().Should().Be(message);
        }

    }
}
