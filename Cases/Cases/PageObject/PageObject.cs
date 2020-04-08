using System;
using OpenQA.Selenium;

namespace Cases.PageObject
{
    public abstract class PageObject
    {
        protected readonly IWebDriver Driver;
        public PageObject(IWebDriver driver) => Driver = driver;
        
    }
}