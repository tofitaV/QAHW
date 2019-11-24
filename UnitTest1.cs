using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Linq;
using System;

namespace NUnitTestProjectTemp
{
    [TestFixture]
    public class Class1
    {
        ChromeDriver driver;

        [SetUp]
        public void SetUpMethod()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void FirstTestMethod()
        {
            try
            {
                driver.Navigate().GoToUrl("https://rozetka.com.ua/");
                Thread.Sleep(2000);
                var searchField = driver.FindElementByXPath("//input[@name='search']");
                searchField.SendKeys("ps4");
                var buttonFiled = driver.FindElementByCssSelector("button.button.button");
                buttonFiled.Click();
                IWebElement[] element = driver.FindElementsByClassName("g-i-tile").Where(e => e.GetAttribute("class").Contains("g-i-tile-catalog")).ToArray();
                var price = element[0].FindElement(By.ClassName("g-price-uah"));
                string priceValue = price.Text;
                Assert.IsTrue(priceValue == "9 499 грн");

            }
            catch
            {
                driver.Quit();
            }
        }

        [TearDown]
        public void TearDownMethod()
        {
            driver.Close();
        }

    }
}