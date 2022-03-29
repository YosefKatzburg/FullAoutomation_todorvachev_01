
using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages
{
    public static class AllPosts
    {
        public static IWebElement Header => Driver.driver.FindElement(By.ClassName("entry-title"));
        public static IWebElement Picture => Driver.driver.FindElement(By.ClassName("entry-thumbnail"));
        public static IWebElement MetaBar => Driver.driver.FindElement(By.ClassName("mh-meta entry-meta"));
        public static IWebElement PreviosBtn => Driver.driver.FindElement(By.CssSelector("#main-content > nav > div.mh-col-1-2.mh-post-nav-item.mh-post-nav-prev"));
        public static IWebElement NextBtn => Driver.driver.FindElement(By.CssSelector("#main-content > nav > div.mh-col-1-2.mh-post-nav-item.mh-post-nav-next"));
        public static IWebElement CommentsTxtInput => Driver.driver.FindElement(By.CssSelector("#mh-comments > ol"));
        public static IWebElement CommentTxtInput => Driver.driver.FindElement(By.CssSelector("comment"));
        public static IWebElement NameTxtInput => Driver.driver.FindElement(By.Id("author"));
        public static IWebElement EmailTxtInput => Driver.driver.FindElement(By.Id("email"));
        public static IWebElement WebsiteTxtInput => Driver.driver.FindElement(By.Id("url"));
        public static IWebElement SaveCheckBox => Driver.driver.FindElement(By.Id("wp-comment-cookies-consent"));
        public static IWebElement PostBtn => Driver.driver.FindElement(By.Name("submit"));
    }
}
