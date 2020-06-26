using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaDefenseCodingProject.PageObjects
{
    class HomePage
    {
        public IWebElement LogInHeaderLink(IWebDriver driver)
        {
            return driver.FindElement(By.Id("nav-link_log-in"));
        }
    }
}
