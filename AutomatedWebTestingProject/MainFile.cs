using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework.Legacy;
using SeleniumExtras.WaitHelpers;

namespace AutomatedWebTestingProject
{
    [TestFixture]
    public class MainFile
    {
        protected IWebDriver driver;
        protected WebDriverWait browserWait;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        protected bool acceptNextAlert = true;
    
        

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver(@"C:\Drivers\chromedriver.exe");
            driver.Manage().Window.Maximize();
            baseURL = "https://www.google.com/";
            browserWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (driver != null)
                {
                    driver.Dispose();
                }
            }

            ClassicAssert.AreEqual("", verificationErrors.ToString());
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        protected string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
