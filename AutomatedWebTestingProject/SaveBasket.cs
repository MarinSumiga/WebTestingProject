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
    public class SaveBasket : MainFile
    {
        
        
        [Test, Order(5)]
        public void TheSaveBasketTest()
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
            driver.FindElement(By.XPath("/html/body/main/div[5]/div[3]/div[1]/div/div/div/div/div/a/picture/img")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//img[@alt='Samsung Galaxy S25 Ultra 12GB/512GB Titanium Black, mobitel']")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.Id("addToCartButton")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("a.btn.btn-primary.btn--continue-shopping[href='/hr/cart']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("a.save__cart--link.cart__head--link.js-save-cart-link")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("saveCartName")).Click();
            driver.FindElement(By.Id("saveCartName")).Clear();
            driver.FindElement(By.Id("saveCartName")).SendKeys("proba");
            driver.FindElement(By.Id("saveCartDescription")).Click();
            driver.FindElement(By.Id("saveCartDescription")).Clear();
            driver.FindElement(By.Id("saveCartDescription")).SendKeys("123123");
            driver.FindElement(By.Id("saveCartButton")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("a.save__cart--link.cart__head--link[href='/hr/my-account/saved-carts']")).Click();
            driver.FindElement(By.XPath("//tr[@id='row-0']/td[14]/a/span")).Click();
            driver.FindElement(By.CssSelector("span.glyphicon.glyphicon-remove")).Click();
            driver.FindElement(By.XPath("//div/div/div/a/img")).Click();
        }
        
    }
}
