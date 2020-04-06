using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Cases.Tests
{
    public class Test1
    {
        private readonly IWebDriver _driver;
        private static string url = "http://automationpractice.com/index.php";

        public Test1()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            _driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Test()
        {
            Console.WriteLine("Testing");
        }
    }
}