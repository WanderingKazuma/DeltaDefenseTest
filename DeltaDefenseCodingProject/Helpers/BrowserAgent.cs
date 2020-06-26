using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DeltaDefenseCodingProject.Helpers
{
    public class BrowserAgent
    {
        IWebDriver driver;

        public enum BrowserType
        {
            Chrome = 0,
            IntenetExplorer = 1,
            Firefox = 2
        }

        public enum Location
        {
            Local = 0,
            Remote = 1
        }

        public IWebDriver createDriver()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            return driver;
        }

        public IWebDriver createDriver(BrowserAgent.BrowserType type, BrowserAgent.Location loc)
        {
            //To Be Completed
            driver = new ChromeDriver();
            return driver;
        }

        public IWebDriver getDriver()
        {
            return driver;
        }




    }
}
