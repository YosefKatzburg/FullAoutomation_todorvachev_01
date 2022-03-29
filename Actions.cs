using FullAoutomation_todorvachev_01.Pages;
using OpenQA.Selenium.Chrome;

namespace FullAoutomation_todorvachev_01
{
    internal class Actions
    {
        public static void InitDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
    }
}
