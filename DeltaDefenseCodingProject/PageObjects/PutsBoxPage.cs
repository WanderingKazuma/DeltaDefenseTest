using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeltaDefenseCodingProject.PageObjects
{
    class PutsBoxPage
    {
        public IWebElement EmailField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("token"));
        }
        public IWebElement CreateInboxButton(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/header/form/button"));
        }
    }
}
