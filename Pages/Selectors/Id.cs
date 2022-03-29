using OpenQA.Selenium;

namespace FullAoutomation_todorvachev_01.Pages
{
    public static class Id
    {
      
        public static IWebElement Picture => Driver.driver.FindElement(By.Id("testImagevc"));
    }   
}
