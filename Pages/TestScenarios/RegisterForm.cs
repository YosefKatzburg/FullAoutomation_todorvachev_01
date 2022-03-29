

using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages.TestScenarios
{
    public static class RegisterForm
    {
        public static IWebElement Introduction => Driver.driver.FindElement(By.CssSelector("#post-70 > div > ul"));
        public static IWebElement UserIdTxtInput => Driver.driver.FindElement(By.Name("userid"));
        public static IWebElement PasswordTxtInput => Driver.driver.FindElement(By.Name("password"));
        public static IWebElement NameTxtInput => Driver.driver.FindElement(By.Name("username"));
        public static IWebElement AddressTxtInput => Driver.driver.FindElement(By.Name("address"));
        public static IWebElement CountryDropDown => Driver.driver.FindElement(By.Name("country"));
        public static IWebElement ZipCodeTxtInput => Driver.driver.FindElement(By.Name("zip"));
        public static IWebElement EmailTxtInput => Driver.driver.FindElement(By.Name("email"));
        public static IWebElement EnglishCheckBox => Driver.driver.FindElement(By.Name("languageQuestion"));
        public static IWebElement AboutTxtInput => Driver.driver.FindElement(By.Id("desc"));
        public static IWebElement RegisterBtn => Driver.driver.FindElement(By.Name("submit"));

        public static IWebElement Country;
        public static IWebElement Sex;

        public static IWebElement ChoosPost(int i)
        {
            Country = Driver.driver.FindElement(By.ClassName($"#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child({i})"));
            return Country;
        } 
        
        public static IWebElement ChoosRdBtn(int i)
        {
            Sex = Driver.driver.FindElement(By.ClassName($"#post-70 > div > form > ul > li:nth-child({i}) > input[type=radio]"));
            return Sex;
        }
    }
}
