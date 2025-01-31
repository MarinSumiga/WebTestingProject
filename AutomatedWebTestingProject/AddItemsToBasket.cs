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
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;

namespace SeleniumTests
{
    [TestFixture]
    public class AddItemsToBasket : MainFile
    {

        [Test, Order(4)]
        public void TheAddItemsToBasketTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            
             
            driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonDecline")).Click();
            
            driver.FindElement(By.LinkText("Elektronika")).Click();
            driver.FindElement(By.XPath("//img[@alt='HR~Mobiteli kucice 390x200 Samsung CRNA.jpg']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form[@id='addToCartFormEK000650636']/button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form[@id='addToCartFormEK000650633']/button")).Click();
            Thread.Sleep(1000);
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Artikli u košarici'])[1]/following::div[15]")).Click();
            //driver.FindElement(By.XPath("(//li/div/div/div/a/div[2]/span")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/cart");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Nastavite na odabir dostave'])[1]/following::button[1]")).Click();
            driver.FindElement(By.XPath("//div/div/div/a/img")).Click();
        }
    }
}
