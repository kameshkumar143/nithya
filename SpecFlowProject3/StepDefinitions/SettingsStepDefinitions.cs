using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class SettingsStepDefinitions
    {
        IWebDriver driver;
        public IWebDriver GetDriver()
        {
            return driver;
        }


        [Given(@"user enters the url")]
        public void GivenUserEntersTheUrl()
        {

            driver = new ChromeDriver();



            driver.Url = "https://energie-app-dev.azurewebsites.net/nl/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"user enters the valid credentials")]
        public void WhenUserEntersTheValidCredentials()
        {
            driver.FindElement(By.Id("email")).SendKeys("AvdilMulaki@mail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("password")).SendKeys("Ho8JLRvL41AWn07Cp1");
            Thread.Sleep(2000);

        }

        [When(@"user click on signin")]
        public void ThenUserClickOnSignin()
        {
            driver.FindElement(By.Id("next")).Click();
        }

        [Then(@"user clicks on settings")]
        public void ThenUserClicksOnSettings()
        {

         
            driver.FindElement(By.XPath("(//div[contains(text(),'Meer')])[1]")).Click();

             }

        [Given(@"click on notifications")]
        public void WhenClickOnNotifications()
        {

           driver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-settings-overview[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[2]")).Click();
        }

        [When(@"then make  allow notifications to enable or disable")]
        public void WhenThenMakeAllowNotificationsToEnableOrDisable()
        {
            driver.FindElement(By.Id("flexSwitchCheckDefault")).Click();
        }

        [When(@"after that enable and disbale the notifications which u want")]
        public void WhenAfterThatEnableAndDisbaleTheNotificationsWhichUWant()
        {
            driver.FindElement(By.Id("flexSwitchCheckDefault")).Click();
        }



        [Given(@"click on feedback")]
        public void GivenClickOnFeedback()
        {
            driver.FindElement(By.XPath("(//div[@class=\"textSettings\"])[2]")).Click();
        }

        [Then(@"enter the feed back")]
        public void ThenEnterTheFeedBack()
        {
            driver.FindElement(By.XPath("//img[@class=\"me-3 mb-3\"]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("exampleFormControlTextarea1")).SendKeys("good and easy to use");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class=\"submit btn btn-primary mt-5\"]")).Click();

        }
        [Given(@"click on accounts")]
        public void GivenClickOnAccounts()
        {
            driver.FindElement(By.XPath("(//div[@class=\"textSettings\"])[3]")).Click();
            Thread.Sleep(2000);
        }

        [Given(@"select logout then main login page will appear")]
        public void GivenSelectLogoutThenMainLoginPageWillAppear()
        {
            driver.FindElement(By.XPath("(//div[@class='logOut'])[2]")).Click(); ;
        }

        [Then(@"select delete account")]
        public void ThenSelectDeleteAccount()
        {
            // driver.FindElement(By.XPath("//div[@class=\"logout mt-2\"]")).Click();
        }

        [Given(@"click on taal")]
        public void GivenClickOnTaal()
        {
            driver.FindElement(By.XPath("(//div[@class=\"textSettings\"])[4]")).Click();
        }

        [Then(@"select the language \(english or dutch\)")]
        public void ThenSelectTheLanguageEnglishOrDutch()
        {
            driver.FindElement(By.XPath("//div[@class=\"dutch ps-4 ng-untouched ng-pristine ng-valid\"][1]")).Click();

            //driver.FindElement(By.XPath("//button[@class=\"dutch ng-untouched ng-pristine ng-v")).Click();
        }
        [Given(@"select the Privacy declaration")]
        public void GivenSelectThePrivacyDeclaration()
        {
            driver.FindElement(By.XPath("(//div[@class=\"textSettings\"])[5]")).Click();
            Thread.Sleep(2000);

        }
        [Then(@"select the Scientific basis")]
        public void ThenSelectTheScientificBasis()
        {
            driver.FindElement(By.XPath("(//div[@class=\"textSettings\"])[6]")).Click();
            Thread.Sleep(2000);
        }



    }
}

