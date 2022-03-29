using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages.TestScenarios
{
    public static class LoginForm
    {
        public static IWebElement Introduction => Driver.driver.FindElement(By.ClassName("#post-74 > div > p"));
        public static IWebElement UsernameTxtInput => Driver.driver.FindElement(By.Name("userid"));
        public static IWebElement PasswordTxtInput => Driver.driver.FindElement(By.Name("passid"));
        public static IWebElement RePasswordTxtInput => Driver.driver.FindElement(By.Name("repeatpassid"));
        public static IWebElement RegisterBtn => Driver.driver.FindElement(By.Name("submit"));
    }
}
