using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class CompanyAdminStepDefinitions
    {

        IWebDriver driver;


        public IWebDriver GetDriver()
        {
            return driver;
        }

        [Given(@"User navigates to the url")]
        public void GivenUserNavigatesToTheUrl()
        {
            driver = new ChromeDriver();


            driver.Url = "https://company-admin-app-dev-as.azurewebsites.net/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Given(@"user enters the valid credentials")]
        public void GivenUserEntersTheValidCredentials()
        {
            driver.FindElement(By.Id("email")).SendKeys("satyaprakashpanda00@gmail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("password")).SendKeys("Ay5qm5C3RfJK21PL6V");

        }

        [Given(@"user sign in to the company admin page")]
        public void GivenUserSignInToTheCompanyAdminPage()
        {
            driver.FindElement(By.Id("next")).Click();
        }

        [Then(@"user clicks on dashboard")]
        public void ThenUserClicksOnDashboard()
        {
            driver.FindElement(By.XPath("//button[contains(text(),' Dashboard ')]")).Click();
        }

        [Given(@"user click the energy analysis")]
        public void GivenUserClickTheEnergyAnalysis()
        {
            driver.FindElement(By.XPath("//span[contains(text(),' Energy Analysis')]")).Click();
        }

        [Given(@"user slects the personal help")]
        public void GivenUserSlectsThePersonalHelp()
        {
            driver.FindElement(By.XPath("//button[contains(text(),' Dashboard ')]")).Click();
        }



        [Given(@"user clicks on personal kwe")]
        public void GivenUserClicksOnPersonalKwe()
        {
            driver.FindElement(By.XPath("//button[contains(text(),' Dashboard ')]")).Click();
        }


        [Then(@"user clicks on stressbrone")]
        public void ThenUserClicksOnStressbrone()
        {
            driver.FindElement(By.XPath("//button[contains(text(),' Dashboard ')]")).Click();
        }
    }

}
