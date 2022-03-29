using OpenQA.Selenium;


namespace FullAoutomation_todorvachev_01.Pages.Test_cases
{
    public static class LoginButtonInLoginForm
    {
        public static IWebElement RegisterBtn => Driver.driver.FindElement(By.Name("testButton"));
    }
}
