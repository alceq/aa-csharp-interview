//using SeleniumExtras.WaitHelpers;
//using Selenium.Support;
//using Selenium.Webdriver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace CodeSolvers.Interview.Tests;

public class Tests
{

    private IWebdriver driver;

    [SetUp]
    public void StartBrowser()
    {
        driver = new ChromeDriver();
        
     
       
        
    }


    [Test]
    public void SauceDemoTest()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
        Assert.Pass();
    }


    [TearDown]
    public void CloseBrowser(){
        driver.Quit();
    }
}

