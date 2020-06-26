using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using DeltaDefenseCodingProject.Helpers;
using System.Threading;
using DeltaDefenseCodingProject.PageObjects;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeltaDefenseCodingProject.StepDefinitions
{
    [Binding]
    public class USCCA_WebsiteTestSteps
    {
        IWebDriver driver;
        BrowserAgent agent = new BrowserAgent();

        HomePage MainPage;
        USCCALoginPage LoginPage;
        USCCASignUpFormPage SignUpFormPage;
        USCCADashboardPage DashboardPage;

        PutsBoxPage PutsBox;

        [Given(@"I have a browser pointed at ""(.*)""")]
        public void GivenIHaveABrowserPointedAt(string p0)
        {
            driver = agent.createDriver();
            driver.Navigate().GoToUrl(p0);

            driver.Manage().Window.Maximize();

        }

        [When(@"I click on the Log In Header Link")]
        public void GivenIClickOnTheLogInHeaderLink()
        {
            MainPage = new HomePage();
            MainPage.LogInHeaderLink(driver).Click();

            Thread.Sleep(1000);
        }

        [When(@"I click on the Sign Up Today Button")]
        public void WhenIClickOnTheSignUpTodayButton()
        {
            LoginPage = new USCCALoginPage();
            LoginPage.SignUpTodayButton(driver).Click();
            Thread.Sleep(1000);
        }

        [Then(@"I should see the sign up Form")]
        public void ThenIShouldSeeTheSignUpForm()
        {
            SignUpFormPage = new USCCASignUpFormPage();
            Assert.IsTrue(SignUpFormPage.FirstNameField(driver).Displayed);
            Thread.Sleep(1000);
        }

        [When(@"I enter in ""(.*)"" into the email textfield")]
        public void WhenIEnterInIntoTheEmailTextfield(string p0)
        {
            PutsBox = new PutsBoxPage();

            PutsBox.EmailField(driver).Clear();
            PutsBox.EmailField(driver).SendKeys(p0);


            Thread.Sleep(1000);
        }

        [When(@"I click Create Inbox")]
        public void WhenIClickCreateInbox()
        {
            PutsBox = new PutsBoxPage();

            PutsBox.CreateInboxButton(driver).Click();

            Thread.Sleep(1000);
        }

        [When(@"I navigate to ""(.*)""")]
        public void WhenINavigateTo(string p0)
        {
            driver.Navigate().GoToUrl(p0);
            Thread.Sleep(1000);
        }

        [When(@"I enter ""(.*)"" for the First Name Field")]
        public void WhenIEnterForTheFirstNameField(string p0)
        {
            SignUpFormPage = new USCCASignUpFormPage();
            SignUpFormPage.FirstNameField(driver).SendKeys(p0);
        }

        [When(@"I enter ""(.*)"" for the Last Name Field")]
        public void WhenIEnterForTheLastNameField(string p0)
        {
            SignUpFormPage = new USCCASignUpFormPage();
            SignUpFormPage.LastNameField(driver).SendKeys(p0);
        }

        [When(@"I enter ""(.*)"" for the Email Field")]
        public void WhenIEnterForTheEmailField(string p0)
        {
            SignUpFormPage = new USCCASignUpFormPage();
            SignUpFormPage.EmailField(driver).SendKeys(p0);
        }

        [When(@"I enter ""(.*)"" for the Password and Password Confirmation Fields")]
        public void WhenIEnterForThePasswordAndPasswordConfirmationFields(string p0)
        {
            SignUpFormPage = new USCCASignUpFormPage();
            SignUpFormPage.PasswordField(driver).SendKeys(p0);
            SignUpFormPage.ConfirmPasswordField(driver).SendKeys(p0);
        }

        [When(@"I click Create Account")]
        public void WhenIClickCreateAccount()
        {
            SignUpFormPage = new USCCASignUpFormPage();
            SignUpFormPage.CreateAccountButton(driver).Click(); 
            Thread.Sleep(1000);
        }

        [Then(@"I should receive an email confirming registration\.")]
        public void ThenIShouldReceiveAnEmailConfirmingRegistration_()
        {
            driver.Navigate().GoToUrl("http://putsbox.com/jy-ddtest-002/inspect");

        }

        [Then(@"I should close the browser")]
        public void ThenIShouldCloseTheBrowser()
        {
            driver.Close();
        }

        [Then(@"I should see a Used Email Error")]
        public void ThenIShouldSeeAUsedEmailError()
        {
            SignUpFormPage = new USCCASignUpFormPage();
            Assert.IsTrue(SignUpFormPage.SignUpEmailError(driver).Displayed);
        }

        [When(@"I enter ""(.*)"" for the Email Login Field")]
        public void WhenIEnterForTheEmailLoginField(string p0)
        {
            LoginPage = new USCCALoginPage();
            LoginPage.EmailLoginField(driver).Clear();
            LoginPage.EmailLoginField(driver).SendKeys(p0);
        }

        [When(@"I click on the Continue Button")]
        public void WhenIClickOnTheContinueButton()
        {
            LoginPage = new USCCALoginPage();
            LoginPage.ContinueButton(driver).Click();
            Thread.Sleep(1000);
        }

        [When(@"I enter ""(.*)"" for the Password Login Field")]
        public void WhenIEnterForThePasswordLoginField(string p0)
        {
            LoginPage = new USCCALoginPage();
            LoginPage.PasswordLoginField(driver).SendKeys(p0);
        }

        [When(@"I click on the Log In Now Button")]
        public void WhenIClickOnTheLogInNowButton()
        {
            LoginPage = new USCCALoginPage();
            LoginPage.LogInNowButton(driver).Click();
            Thread.Sleep(2000);
        }

        [When(@"I click Account Details LinkGroup")]
        public void WhenIClickAccountDetailsLinkGroup()
        {
            DashboardPage = new USCCADashboardPage();
            DashboardPage.AccountDetailsLink(driver).Click();
        }

        [When(@"I click on Contact Information")]
        public void WhenIClickOnContactInformation()
        {
            DashboardPage = new USCCADashboardPage();
            DashboardPage.ContactInformationLink(driver).Click();
            Thread.Sleep(1000);
        }

        [When(@"I click on Edit Password Link")]
        public void WhenIClickOnEditPasswordLink()
        {
            DashboardPage = new USCCADashboardPage();
            DashboardPage.EditPasswordLink(driver).Click();

        }

        [When(@"I enter new Password ""(.*)"" and select Update")]
        public void WhenIEnterNewPasswordAndSelectUpdate(string p0)
        {
            DashboardPage = new USCCADashboardPage();
            DashboardPage.NewPasswordTextField(driver).Clear();
            DashboardPage.NewPasswordTextField(driver).SendKeys(p0);
            DashboardPage.ConfirmNewPasswordTextField(driver).Clear();
            DashboardPage.ConfirmNewPasswordTextField(driver).SendKeys(p0);

            DashboardPage.UpdatePasswordButton(driver).Click();
        }

        [When(@"I click Log Out in the Header")]
        public void WhenIClickLogOutInTheHeader()
        {
            driver.Navigate().GoToUrl("https://www.usconcealedcarry.com/logout/");
            Thread.Sleep(1000);
        }

        [When(@"I click on Education and Training")]
        public void WhenIClickOnEducationAndTraining()
        {
            DashboardPage = new USCCADashboardPage();
            DashboardPage.EducationAndTraining(driver).Click();
            DashboardPage.VideosSubNavLink(driver).Click();
            Thread.Sleep(1000);
        }

        [Then(@"I should see the available videos")]
        public void ThenIShouldSeeTheAvailableVideos()
        {
            Assert.IsTrue(driver.FindElement(By.ClassName("wistia-cta__thumb")).Displayed);
        }

        [Then(@"I can export these headers into an excel file")]
        public void ThenICanExportTheseHeadersIntoAnExcelFile()
        {
            IList<IWebElement> ElementsArray = driver.FindElements(By.ClassName("wistia-cta__thumb"));
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string p0)
        {
            DashboardPage = new USCCADashboardPage();
            DashboardPage.NavSearchButton(driver).Click();
            DashboardPage.NavSearchField(driver).SendKeys(p0);
            DashboardPage.NavSearchField(driver).SendKeys(Keys.Enter);
        }

        [When(@"I click on the first link")]
        public void WhenIClickOnTheFirstLink()
        {
            driver.FindElement(By.XPath("/html/body/main/div/div/div/a[1]/h2")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"I should see (.*) of the reasons to join")]
        public void ThenIShouldSeeOfTheReasonsToJoin(int p0)
        {
            Assert.IsTrue(driver.FindElement(By.TagName("h2")).Displayed);
        }




    }
}
