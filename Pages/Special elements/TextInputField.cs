﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAoutomation_todorvachev_01.Pages.Special_elements
{
    internal class TextInputField
    {
        public static IWebElement InputTxtField => Driver.driver.FindElement(By.Name("username"));
    }
}
