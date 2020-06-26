using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaDefenseCodingProject.PageObjects
{
    class USCCALoginPage
    {
        public IWebElement SignUpTodayButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("signUpTodayButton"));
        }

        public IWebElement EmailLoginField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("signinEmail"));
        }

        public IWebElement ContinueButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("continueButton"));
        }

        public IWebElement PasswordLoginField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("signinPassword"));
        }

        public IWebElement LogInNowButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("signInSignInButton"));
        }
    }
}
