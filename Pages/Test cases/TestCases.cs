

using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages.Test_cases
{
    internal class TestCases
    {
        public static IWebElement ItemsInDropDown => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-78.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a"));
        public static IWebElement LoginBtnInLoginForm => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-76.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a"));
        public static IWebElement  UserNameFieldInLoginForm => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div > header > h3 > a"));
    }
}
