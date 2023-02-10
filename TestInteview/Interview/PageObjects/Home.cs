using System;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Interview.PageObjects
{

    class Home: DriverHelper
        
    {   
            
            public IWebElement title = DriverHelper.driver.FindElement(By.ClassName("Title"));
            public IWebElement login = DriverHelper.driver.FindElement(By.LinkText("Log In"));
            public IWebElement fName = DriverHelper.driver.FindElement(By.Id("firstName"));
            public IWebElement auto = DriverHelper.driver.FindElement(By.Id("Interests_0_"));
            public IWebElement lNameError = DriverHelper.driver.FindElement(By.Id("lastName-error"));
            public IWebElement fNameError = DriverHelper.driver.FindElement(By.Id("firstName-error"));
            public IWebElement submit = DriverHelper.driver.FindElement(By.LinkText("Submit"));

     
    }
    class DriverHelper
    {
        public static IWebDriver driver { get; set; }
        public void SetupEnvironment()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ssfcu.org/insurance/personal/request-a-quote");
        }
    }

   
}
