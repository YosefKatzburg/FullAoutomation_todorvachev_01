
using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages.About
{
    public static class About
    {
        public static IWebElement Introduction => Driver.driver.FindElement(By.Id(""));
        public static IWebElement Comment => Driver.driver.FindElement(By.Id(""));
        public static IWebElement NameTxtInput => Driver.driver.FindElement(By.Id(""));
        public static IWebElement EmailTxtInput => Driver.driver.FindElement(By.Id(""));
        public static IWebElement WebsiteTxtInput => Driver.driver.FindElement(By.Id(""));
        public static IWebElement SaveCheckBox => Driver.driver.FindElement(By.Id(""));
        public static IWebElement PostBtn => Driver.driver.FindElement(By.Id(""));
    }
}
