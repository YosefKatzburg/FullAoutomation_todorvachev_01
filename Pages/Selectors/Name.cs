using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages
{
    internal class Name
    {
        public static IWebElement InputTxtField => Driver.driver.FindElement(By.Name("myName"));
    }
}
