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
        private readonly By logoButton = By.XPath("//img[@class='header-logo-image logo']");
        private readonly By dropdownCatalogButton = By.XPath("//button[@class='btn btn-primary dropdown-toggle']");
        private readonly By shirtsCatalogButton = By.XPath("//a[text()='–”¡¿ÿ »']");
        private readonly By shirtsComfortCatalogButton = By.XPath("/html/body/div[2]/div/div[1]/ul/li[3]/a");
        private readonly By accessoriesCatalogButton = By.XPath("//a[text()='¿ —≈——”¿–€']");
        private readonly By hatsAccessoriesCatalogButton = By.XPath("/html/body/div[2]/div/div[1]/ul/li[2]/a");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("http://lee-cooper.by");
        }

        [Test]
        public void LogoButtonTest()
        {
            var catalog = driver.FindElement(logoButton);
            catalog.Click();
        }

        [Test]
        public void ComfortShirtsButtonTest()
        {
            var catalog = driver.FindElement(dropdownCatalogButton);
            catalog.Click();
            var shirts = driver.FindElement(shirtsCatalogButton);
            shirts.Click();
            var shirtsComfort = driver.FindElement(shirtsComfortCatalogButton);
            shirtsComfort.Click();
        }

        [Test]
        public void CheapFirstComfortShirtsButtonTest()
        {
            var catalog = driver.FindElement(dropdownCatalogButton);
            catalog.Click();
            var accessories = driver.FindElement(accessoriesCatalogButton);
            accessories.Click();
            var hats = driver.FindElement(hatsAccessoriesCatalogButton);
            hats.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
