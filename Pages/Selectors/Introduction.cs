using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages
{
    internal class Introduction
    {

        IWebElement Header => Driver.driver.FindElement(By.ClassName("entry-title page-title"));
        IWebElement Picture => Driver.driver.FindElement(By.ClassName("alignnone wp-image-37 size-full"));
    }
}
