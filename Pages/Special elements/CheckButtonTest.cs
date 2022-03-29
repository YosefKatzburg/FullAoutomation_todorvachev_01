using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAoutomation_todorvachev_01.Pages.Special_elements
{
    internal class CheckButtonTest
    {
        public static IWebElement checkbox => Driver.driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)"));
        public static IWebElement checkbox2 => Driver.driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));
        public static IWebElement W3SchoolsLink => Driver.driver.FindElement(By.CssSelector("#post-33 > div > h6 > a"));
    }
}
