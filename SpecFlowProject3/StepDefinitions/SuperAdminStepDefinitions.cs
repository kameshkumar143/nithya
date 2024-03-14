using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.ComponentModel.Design;
using java.util.concurrent;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class SuperAdminStepDefinitions
    {
        IWebDriver driver;


        public IWebDriver GetDriver()
        {
            return driver;
        }
        [Given(@"navigate to the  url")]
        public void GivenNavigateToTheUrl()
        {
            driver = new ChromeDriver();


            // driver.Url = "https://enrgie-app-super-admin.azurewebsites.net/";
            driver.Url = "https://energie-superadmin-dev.azurewebsites.net/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [When(@"user should enter the mail")]
        public void WhenUserShouldEnterTheMail()
        {
            driver.FindElement(By.Id("i0116")).SendKeys("dnithya@ariqt.com");
            Thread.Sleep(2000);
        }

        [When(@"user should click on next")]
        public void WhenUserShouldClickOnNext()
        {
            driver.FindElement(By.Id("idSIButton9")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user should enter the password")]
        public void WhenUserShouldEnterThePassword()
        {
            driver.FindElement(By.Id("i0118")).SendKeys("Surya1@vardhan");
            Thread.Sleep(2000);
        }

        [When(@"user should click on signin button")]
        public void WhenUserShouldClickOnSigninButton()
        {
            driver.FindElement(By.XPath("//input[@value=\"Sign in\"]")).Click();

        }

        [Then(@"user either selects yes or no")]
        public void WhenUserEitherSelectsYesOrNo()
        {
            driver.FindElement(By.Id("idBtn_Back")).Click();

           
        }



        [When(@"superadmin should enter valid name")]
        public void WhenSuperadminShouldEnterValidName()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname=\"userName\"]")).SendKeys("NithyaReddy");
            Thread.Sleep(3000);         
        }

        [When(@"superadmin should enter valid emailid")]
        public void WhenSuperadminShouldEnterValidEmailid()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname=\"email\"]")).SendKeys("NithyaReddy12@gmail.com");
            Thread.Sleep(3000);
        }

        [When(@"superadmin should select a companyname")]
        public void WhenSuperadminShouldSelectACompanyname()
        {
            driver.FindElement(By.XPath("//option[@class=\"prompt\"][2]")).Click();
            Thread.Sleep(3000);
        }

        [Then(@"superadmin should click on submit button")]
        public void ThenSuperadminShouldClickOnSubmitButton()
        {
            driver.FindElement(By.XPath("/html/body/app-root/app-sign-up/div[2]/div[2]/div[2]/div/form/button/span")).Click();
        }

        [When(@"super admin click on addcompany")]
        public void WhenSuperAdminClickOnAddcompany()
        {
            driver.FindElement(By.XPath("/html/body/app-root/app-sign-up/div[2]/div[2]/div[2]/div/form/div/button")).Click();
            Thread.Sleep(3000);
        }

        [When(@"superadmin should enter valid companyname")]
        public void WhenSuperadminShouldEnterValidCompanyname()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname=\"newCompany\"]")).SendKeys("rto");
            Thread.Sleep(3000);

        }

        [Then(@"superadmin should cilck on click to add button")]
        public void ThenSuperadminShouldCilckOnClickToAddButton()
        {
            driver.FindElement(By.XPath("/html/body/app-root/app-sign-up/div[1]/div/div/div/div[2]/button")).Click();
            Thread.Sleep(3000);
        }

    }
}
