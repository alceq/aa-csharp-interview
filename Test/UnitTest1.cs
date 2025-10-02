using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 

namespace Test
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
            driver = null;
        }

        [Test]
        public void Test1()
        {
            driver!.Navigate().GoToUrl("https://www.saucedemo.com");
            Assert.That(driver.Title, Is.EqualTo("Swag Labs"));

            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => d.Url.Contains("inventory"));

            Assert.That(driver.Url, Does.Contain("inventory"));
        }
    }
}


