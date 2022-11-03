using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Collections.Generic;

namespace WebDriverTests
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By CatalogButton = By.XPath("//a[text()=' ‡Ú‡ÎÓ„']");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("http://lee-cooper.by");
        }

        [Test]
        public void CatalogButtonTest()
        {
            var catalog = driver.FindElement(CatalogButton);
            catalog.Click();
        }

        [Test]
        public void WomenButtonTest()
        {
            var catalog = driver.FindElement(CatalogButton);
            catalog.Click();
            var women = driver.FindElement(By.LinkText("∆≈ÕŸ»Õ¿Ã"));
            women.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
