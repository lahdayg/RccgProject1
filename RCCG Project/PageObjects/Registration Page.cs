using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RCCG_Project.Utilities;

namespace RCCG_Project.PageObjects
{
    public class Registration_Page
    {
        public Registration_Page()
        {
            PageFactory.InitElements(Hooks.Driver, this);


        }



        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }


        public void ClickOnRegister()

        {
            register.Click();
        }


        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        public void EnterFirstName()

        {
            firstName.SendKeys("akin");
        }


        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        public void EnterLastName()

        {
            lastName.SendKeys("oladeji");
        }



        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        public void EnterEmailAddress(string mymail)

        {
            emailAddress.SendKeys("lahdayg@yahoo.com");

        }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobile { get; set; }

        public void EnterMobileNumber()

        {
            mobile.SendKeys("07515003304");
        }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement { get; set; }

        public void TypePassword()
        {
            passwordElement.SendKeys("12345");
        }


        [FindsBy(How = How.Id, Using = "id=confirm_password")]
        private IWebElement ConfirmPassword { get; set; }

        public void EnterPassword()
        {
            passwordElement.SendKeys("12345");
        }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signup { get; set; }

        public void ClickSignUp()

        {
            signup.Click();
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='signup - form']/div[5]/label[2]")]
        private IWebElement passwordTooShortMessage { get; set; }

        public bool PasswordTooShortMessageIsDisplayed()
        {
            try
            {
                return passwordTooShortMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement successMessage { get; set; }

        public bool SuccessMessageIsDisplayed()
        {
            try
            {
                return successMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }

        }    public string GetTextForPasswordTooShort()
        {
            string text = passwordTooShortMessage.Text;
            return text;
        }

        

    }
        }






       

