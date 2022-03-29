

using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages
{
    internal class Selectors
    {
        public static IWebElement Name => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-111.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a"));
        public static IWebElement Id => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-110.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a"));
        public static IWebElement XPath => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-109.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a"));
        public static IWebElement CssPath => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-108.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a"));
        public static IWebElement ClassName => Driver.driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-107.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a"));
    }
}
