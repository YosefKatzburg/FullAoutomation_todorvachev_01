

using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages
{
    public static class AllPages
    {
        public static IWebElement Header => Driver.driver.FindElement(By.ClassName("mh-site-logo"));
        public static IWebElement SearchBar => Driver.driver.FindElement(By.Id("search-2"));
        public static IWebElement CopyRightsTxt => Driver.driver.FindElement(By.ClassName("mh-copyright-wrap"));
        public static class TopToolBar
        {
            public static IWebElement IntroBtn => Driver.driver.FindElement(By.Id("menu-item-25"));
            public static IWebElement SelectorsBtn => Driver.driver.FindElement(By.Id("menu-item-106"));
            public static IWebElement SpecialElementsBtn => Driver.driver.FindElement(By.Id("menu-item-35"));
            public static IWebElement TestCasesBtn => Driver.driver.FindElement(By.Id("menu-item-57"));
            public static IWebElement TestScenariosBtn => Driver.driver.FindElement(By.Id("menu-item-58"));
            public static IWebElement AboutBtn => Driver.driver.FindElement(By.Id("menu-item16-26"));
        }

        public static class RightToolBar
        {
            public static class RecentPosts
            {
                public static IWebElement RecentPost;

                public static IWebElement ChoosPost(int i)
                {
                    RecentPost  = Driver.driver.FindElement(By.ClassName($"#recent-posts-2 > ul > li:nth-child({i}) > a"));
                    return RecentPost;
                }
            }
        }
        public static class Categories
        {
            public static IWebElement SelectCategoryDropDown => Driver.driver.FindElement(By.Id("cat"));
            public static IWebElement ChosenPost;

            public static IWebElement SelectCategory(int i)
            {
                ChosenPost = Driver.driver.FindElement(By.CssSelector($"#cat > option:nth-child({i})"));
                return ChosenPost;
            }
        }
        public static class Meta
        {

            public static IWebElement ChosenPost;

            public static IWebElement SelectCategory(int i)
            {
                ChosenPost = Driver.driver.FindElement(By.CssSelector($"# meta-2 > ul > li:nth-child({i})"));
                return ChosenPost;
            }
        }
    }
}

