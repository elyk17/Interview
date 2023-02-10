using Interview.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace Interview.Tests
{
    /// <summary>
    /// 
    /// Please take time to read all instructions carefully before starting.
    /// 
    /// This exercise is intended to test your problem solving skills, knowledge of C#, Selenium, HTML/CSS, and OO principals and design.  Feel free to use
    /// books or internet references to complete this exercise but please do not get help from others in any way or discuss this exercise with others.
    /// 
    /// </summary>
  
    class TakeHomeExercise: DriverHelper
    {
        /// <summary>
        /// 
        /// Using C# and Selenium, please automate the test steps provided below:
        /// 1. Navigate to the "Request an Insurance Quote" page on our website, https://www.ssfcu.org/insurance/personal/request-a-quote
        /// 2. Assert the page title using the variable, pageTitle
        /// 3. Fill in ONLY the first name field using the variable, firstName
        /// 4. Check "Auto" under Interest using the variable, interest
        /// 5. Click Submit
        /// 6. Assert that the First Name field does not have an error message
        /// 7. Assert that the Last Name field has an error message using the variable, lastNameErrorMessage
        /// 
        /// Create a page object for the quote form page linked above that provides the functionality needed to complete this scenario
        /// using the variables provided. Please do not use PageFactory.
        /// 
        /// Your finished script should compile and run successfully using the Chrome browser.
        /// </summary>
        /// 
        Home home = new Home();


        [SetUp]
        public void setup()
        {
            SetupEnvironment();
        }

        [Test]
        public void TakeHomeExercise1()
        {
            string firstName = "Security";
            string interest = "Auto";
            string lastNameErrorMessage = "Response required";
            string pageTitle = "Get a Quote";
            driver.g

            Assert.AreEqual(pageTitle, home.title.Text.ToString());

            Actions action = new Actions(driver);
            action.MoveToElement(home.fName);
            action.Perform();

            home.fName.SendKeys(firstName);
            if(home.fName.Text == firstName)
            {
                Console.WriteLine("first name contains Security");
            }
            else
            {
                throw new Exception("first name doesn't contain Security");
            }
            Assert.AreEqual(home.auto.Text, interest);
            home.auto.Click();

            home.submit.Click();
            
            if(home.fNameError.Displayed)
            {
                throw new Exception("First Name Error showing erroneously");
            }
            if(home.lNameError.Displayed)
            {
                Assert.AreEqual(home.lNameError.Text,lastNameErrorMessage);
                
            }

        }
        [TearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}