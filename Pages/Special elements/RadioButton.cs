using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAoutomation_todorvachev_01.Pages.Special_elements
{
    public class RadioButton
    {
       
        public static IWebElement W3SchoolsLink => Driver.driver.FindElement(By.Id("#post-10 > div > h6 > a"));
        public static IWebElement RadioBtn;

        public static IWebElement SelectCategory(int i)
        {
            RadioBtn = Driver.driver.FindElement(By.CssSelector($"#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child({i})"));
            return RadioBtn;
        }
    }
}
