

using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages.Special_elements
{
    public class DropDownTest
    {
        public static IWebElement DropDown => Driver.driver.FindElement(By.Name("DropDownTest"));
        public static IWebElement W3SchoolsLink => Driver.driver.FindElement(By.CssSelector("#post-6 > div > h6 > a"));

        public static IWebElement Select;

        public static IWebElement SelectCategory(int i)
        {
            Select = Driver.driver.FindElement(By.CssSelector($"#post-6 > div > p:nth-child(6) > select > option:nth-child({i})"));
            return Select;
        }
    }
}
