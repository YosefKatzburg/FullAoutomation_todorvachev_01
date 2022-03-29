

using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages.Special_elements
{
    internal class SpesialElements
    {
        public static IWebElement AlertBox => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-119.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a"));
        public static IWebElement TxtInputField => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-59.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a"));
        public static IWebElement CheckButtonTest => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-33.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a"));
        public static IWebElement RadioButtonTest => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-10.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a"));
        public static IWebElement DropDownTest => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-6.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div > header > h3 > a"));
    }
}
