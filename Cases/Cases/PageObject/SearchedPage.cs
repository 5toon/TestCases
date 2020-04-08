using OpenQA.Selenium;

namespace Cases.PageObject
{
    public class SearchedPage : PageObject
    {
        private static readonly By AddToCardButton = By
            .XPath("//*[@id=\"center_column\"]/ul/li/div/div[2]/div[2]/a[1]");
        public SearchedPage(IWebDriver driver) : base(driver)
        {
        }

        public SearchedPage AddButton()
        {
            Driver.FindElement(AddToCardButton).Click();
            return this;
        }
        
    }
}