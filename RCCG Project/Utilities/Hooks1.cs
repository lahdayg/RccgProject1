using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace RCCG_Project.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver Driver;
    
        

        
    
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver = new FirefoxDriver();
        }
        
   

  

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
