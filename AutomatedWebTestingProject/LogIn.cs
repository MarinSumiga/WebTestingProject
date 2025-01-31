using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AutomatedWebTestingProject;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class LogIn : MainFile
    {




        [Test, Order(1)]
        public void TheLogInTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonDecline")).Click();
            //driver.Navigate().GoToUrl("https://www.google.com/search?q=ekupi&oq=ekup&gs_lcrp=EgZjaHJvbWUqDggAEEUYJxg7GIAEGIoFMg4IABBFGCcYOxiABBiKBTIGCAEQRRg5Mg0IAhAAGJECGIAEGIoFMg0IAxAAGJECGIAEGIoFMgcIBBAAGIAEMgcIBRAAGIAEMgcIBhAAGIAEMgcIBxAAGIAEMgcICBAAGIAEMgcICRAAGIAE0gEJMjg2M2owajE1qAIIsAIB&sourceid=chrome&ie=UTF-8");
            //driver.FindElement(By.XPath("//div[@id='rso']/div/div/div/div/div/div/div/div/div/div/div/span/a/h3")).Click();
            driver.FindElement(By.LinkText("Prijava / Registracija")).Click();
            driver.FindElement(By.Id("j_username")).Click();
            driver.FindElement(By.Id("j_username")).Clear();
            driver.FindElement(By.Id("j_username")).SendKeys("marinproba@gmail.com");
            driver.FindElement(By.Id("j_password")).Click();
            driver.FindElement(By.Id("j_password")).Clear();
            driver.FindElement(By.Id("j_password")).SendKeys("Marinproba0905");
            driver.FindElement(By.Id("submit")).Click();
        }





    }
}
