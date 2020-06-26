using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeltaDefenseCodingProject.PageObjects
{
    class USCCADashboardPage
    {

        public IWebElement AccountDetailsLink(IWebDriver driver)
        {
            return driver.FindElement(By.Id("accountDetailsNav"));
        }

        public IWebElement ContactInformationLink(IWebDriver driver)
        {
            return driver.FindElement(By.Id("contactInformation"));
        }

        public IWebElement EditPasswordLink(IWebDriver driver)
        {
            return driver.FindElement(By.Id("passwordEdit"));
        }

        public IWebElement NewPasswordTextField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("password-information-password"));
        }

        public IWebElement ConfirmNewPasswordTextField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("password-information-confirm-password"));
        }

        public IWebElement UpdatePasswordButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("passwordSave"));
        }

        public IWebElement LogOutButton(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("LOG OUT"));
        }

        public IWebElement EducationAndTraining(IWebDriver driver)
        {
            return driver.FindElement(By.Id("educationTrainingNav"));
        }

        public IWebElement VideosSubNavLink(IWebDriver driver)
        {
            return driver.FindElement(By.Id("videos"));
        }

        public IWebElement NavSearchButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("nav-link_search"));
        }

        public IWebElement NavSearchField(IWebDriver driver)
        {
            return driver.FindElement(By.Id("nav-link_search_field"));
        }
    }
}
