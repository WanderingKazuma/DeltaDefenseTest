using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeltaDefenseCodingProject.PageObjects
{
    class USCCASignUpFormPage
    {
        public IWebElement FirstNameField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("createAccountFirstName"));
        }
        public IWebElement LastNameField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("createAccountLastName"));
        }
        public IWebElement EmailField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("createAccountEmail"));
        }
        public IWebElement PasswordField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("createAccountPassword"));
        }
        public IWebElement ConfirmPasswordField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("createAccountReEnterPassword"));
        }        
        public IWebElement CreateAccountButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("createAccountSignUpButton"));
        }

        public IWebElement SignUpEmailError(IWebDriver driver)
        {
            return driver.FindElement(By.ClassName("input--error"));
        }
    }
}
