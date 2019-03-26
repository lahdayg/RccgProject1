using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace RCCG_Project.TraditionalSeleniumWithoutSpecflow
{
    [TestClass]
    public class TraditionalSelenium
    {
        [TestMethod]
        public void TestMethod1()
        {

            //1. create instance of the browser
            IWebDriver Driver;

            //2. open the browser
            Driver = new ChromeDriver();

            //3. Do your test

            //3a. Navigate to website
            Driver.Navigate().GoToUrl("http://blueskycitadel.com/test-form-for-bluesky-automation-training/");
            Driver.Manage().Window.Maximize();
            //3b. Enter a text into textbox

            //3b i) Inspect your element

            //3b ii) Decide on the attribute to use to find your element

            //3b iii) Copy the attribute

            //3b iv) Write the code to find the element
            Driver.FindElement(By.Id("nf-field-26"));

            //3b v) Perform the action (ie type into the textbox)
            Driver.FindElement(By.Id("nf-field-26")).SendKeys("akino");

            Driver.FindElement(By.Id("nf-field-27")).SendKeys("olumide");

            //3c. Select from a drop list

            //3c iv a) Find the element for the select
            // Driver.FindElement(By.Id("nf-field-41"));

            //3c iv b) Use the element you found with the SelectElement Instance
            SelectElement multiselect = new SelectElement(Driver.FindElement(By.Id("nf-field-41")));

            //3c iv c) Select the option from the list
            multiselect.SelectByValue("one");

            multiselect.SelectByValue("two");

            multiselect.SelectByText("Three");

            //3c I Select Drop list

            // SelectElement country = new SelectElement(Driver.FindElement(By.Id("nf-field-43")));
            new SelectElement(Driver.FindElement(By.Id("nf-field-43"))).SelectByValue("two");
            //country.SelectByText("Three");



            //3d. write the code to find the elemet


            // IWebElement radio = Driver.FindElement(By.XPath("//*[@id='nf - field - 31 - 0']"));

            //3d 1)click on the element 
            // radio.Click();
            Driver.FindElement(By.XPath("//*[@id='nf-field-31-0']")).Click();


            //3e. Typing into a paragraph textbox
            Driver.FindElement(By.CssSelector("#nf-field-44")).SendKeys("my long story is long overdue");



            //3e. click a submit button

            Driver.FindElement(By.Id("nf-field-37")).Click();

            // 4 Validate if success message displayed

            //Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed;
            //Thread.Sleep(5000);

            //Implicit Waits
            //Tell your WebDriver to poll the DOM  for certain amount of time in order to find the element
            //By default it is set to zero

            //When do I need to wait / when is it required

            //a) For your page to load
            //b) For a java script or ajax to finish
            //c) when new form or message is displayed/uploaded onto a form

            // Implicit Waits
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Explicit Waits
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver web) =>
            {
                web.FindElement("By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p"));
                    { 
                    return true;
                }
                


            });





            //Assert the displayed object
            Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed);

           // Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed)),"The message is not displayed"();



            //4. close browser
            //Driver.Close();

            // Waiting

            //Thread.Sleep(5000)

        }
    }
}
