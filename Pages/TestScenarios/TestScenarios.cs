

using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages.TestScenarios
{
    public static class TestScenarios
    {
        public static IWebElement LoginForn => Driver.driver.FindElement(By.ClassName("mh-loop-item mh-clearfix post-72 post type-post status-publish format-standard has-post-thumbnail hentry category-test-scenarios"));
        public static IWebElement RegisterForm => Driver.driver.FindElement(By.ClassName("mh-loop-item mh-clearfix post-70 post type-post status-publish format-standard has-post-thumbnail hentry category-test-scenarios"));
    }
}
