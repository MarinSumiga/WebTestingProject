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
    public class CompareItems : MainFile
    {
        [Test, Order(3)]
        public void TheCompareItemsTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            
            driver.FindElement(By.Id("CybotCookiebotDialogBodyButtonDecline")).Click();
            
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Platna'])[1]/following::a[1]")).Click();
            driver.FindElement(By.XPath("//img[@alt='gaming laptopi']")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/Ra%C4%8Dunala/Laptopi-i-oprema/Laptopi/Gaming-laptopi/c/13126");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[4]/div/div/div[4]/label/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[2]/div/div/div[4]/label/input")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("product-compare-button")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/productcompare/compare?product=EK000605454&product=EK000523825");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form[@id='addToCartFormEK000605454']/button")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Artikli u košarici'])[1]/following::div[15]")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/cart");
        }
        
    }
}
