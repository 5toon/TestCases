using OpenQA.Selenium;

namespace Cases.PageObject
{
    public class Header : PageObject
    {
        private const string SearchedText = "Blouse";
        private static readonly By SearchField = By.Id("search_query_top");
        private static readonly By SearchButton = By.Name("submit_search");
        
        public Header(IWebDriver driver) : base(driver)
        {
        }

        public void SearchObject()
        {
            Driver.FindElement(SearchField).Click();
            Driver.FindElement(SearchField).Clear();
            Driver.FindElement(SearchField).SendKeys(SearchedText);
        }

        public  SearchedPage SearchClickButton()
        {
            Driver.FindElement(SearchButton);
            return new SearchedPage(Driver);
        }
    }
}