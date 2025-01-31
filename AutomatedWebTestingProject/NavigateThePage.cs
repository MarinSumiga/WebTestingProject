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
    public class NavigateThePage : MainFile
    {
        
        
        [Test, Order(2)]
        public void TheNavigateThePageTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");

            driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonDecline")).Click();

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Platna'])[1]/following::a[1]")).Click();
            driver.FindElement(By.XPath("//img[@alt='gaming komponente']")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/Ra%C4%8Dunala/Ra%C4%8Dunala-i-periferija/Ra%C4%8Dunalne-komponente/c/10075");
            driver.FindElement(By.Id("sortOptions1")).Click();
            new SelectElement(driver.FindElement(By.Id("sortOptions1"))).SelectByText("Najvišoj ocjeni");
            driver.FindElement(By.LinkText("E-mobility")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/E-mobility/c/13183");
            driver.FindElement(By.LinkText("Alati i strojevi")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/Alati-i-strojevi/c/10037");
            driver.FindElement(By.LinkText("Dom i vrt")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/Dom-i-vrt/c/10006");
            driver.FindElement(By.XPath("//div/div/div/a/img")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            driver.FindElement(By.LinkText("Knjige, škola i ured")).Click();
            driver.FindElement(By.LinkText("Fitness")).Click();
        }
        
    }
}
