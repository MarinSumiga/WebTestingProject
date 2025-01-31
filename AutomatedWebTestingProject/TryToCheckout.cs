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
    public class TryToCheckout : MainFile
    {

        [Test, Order(6)]
        public void TheTryToCheckoutTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");

            driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonDecline")).Click();

            driver.FindElement(By.LinkText("Elektronika")).Click();
            driver.FindElement(By.XPath("//img[@alt='HR~Mobiteli kucice 390x200 Samsung CRNA.jpg']")).Click();
            driver.FindElement(By.CssSelector("body > main > div.main__inner-wrapper > div.row > div.col-sm-12.col-md-9.col-lg-10 > div > div:nth-child(2) > div.product__listing.product__grid > div:nth-child(1) > div.gtag-wraper > a > img")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"addToCartButton\"]")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.XPath("//*[@id=\"cboxLoadedContent\"]/div/div[3]/a[2]")).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.CssSelector(".js-continue-checkout-button")).Click();
            driver.FindElement(By.Id("j_username")).Click();
            driver.FindElement(By.Id("j_username")).Clear();
            driver.FindElement(By.Id("j_username")).SendKeys("marinproba@gmail.com");
            driver.FindElement(By.Id("j_password")).Click();
            driver.FindElement(By.Id("j_password")).Clear();
            driver.FindElement(By.Id("j_password")).SendKeys("Marinproba0905");
            driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(3500);
            driver.FindElement(By.CssSelector(".js-continue-checkout-button")).Click();
            driver.FindElement(By.Id("address.firstName")).Click();
            driver.FindElement(By.Id("address.firstName")).Clear();
            driver.FindElement(By.Id("address.firstName")).SendKeys("marin");
            driver.FindElement(By.Id("address.surname")).Click();
            driver.FindElement(By.Id("address.surname")).Clear();
            driver.FindElement(By.Id("address.surname")).SendKeys("proba");
            driver.FindElement(By.Id("address.line1")).Click();
            driver.FindElement(By.Id("address.line1")).Clear();
            driver.FindElement(By.Id("address.line1")).SendKeys("dsakso 15");
            driver.FindElement(By.XPath("//div[@id='addressFormElementsToBeDisabled']/div/div[8]")).Click();
            driver.FindElement(By.Id("address.postcode")).Click();
            Thread.Sleep(1550);
            driver.FindElement(By.Id("address.phone")).Click();
            driver.FindElement(By.Id("address.phone")).Clear();
            driver.FindElement(By.Id("address.phone")).SendKeys("45999932");
            driver.FindElement(By.Id("addressSubmit")).Click();
        }
    }
}
