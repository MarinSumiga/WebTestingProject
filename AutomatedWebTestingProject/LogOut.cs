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
    public class LogOut : MainFile
    {
        
        
        [Test, Order(7)]
        public void TheLogOutTest()
        {

            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonDecline")).Click();

            driver.FindElement(By.LinkText("Prijava / Registracija")).Click();
            driver.FindElement(By.Id("j_username")).Click();
            driver.FindElement(By.Id("j_username")).Clear();
            driver.FindElement(By.Id("j_username")).SendKeys("marinproba@gmail.com");
            driver.FindElement(By.Id("j_password")).Click();
            driver.FindElement(By.Id("j_password")).Clear();
            driver.FindElement(By.Id("j_password")).SendKeys("Marinproba0905");
            driver.FindElement(By.Id("submit")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            driver.FindElement(By.XPath("//div/div/div/a/img")).Click();
            driver.FindElement(By.LinkText("Odjavite se")).Click();
        }
        
    }
}
