using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class PlanStepDefinitions
    {

        IWebDriver driver;
        public IWebDriver GetDriver()
        {
            return driver;
        }

        [Given(@"user navigate to url")]
        public void GivenUserNavigateToUrl()
        {

            driver = new ChromeDriver();



            driver.Url = "https://energie-app-dev.azurewebsites.net/nl/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"user enters all valid details")]
        public void WhenUserEntersAllValidDetails()
        {
            driver.FindElement(By.Id("email")).SendKeys("AvdilMulaki@mail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("password")).SendKeys("Ho8JLRvL41AWn07Cp1");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("next")).Click();
            Thread.Sleep(2000);

        }


        [Given(@"user clicks on plan")]
        public void GivenUserClicksOnPlan()
        {
            driver.FindElement(By.XPath("//div[@id='personalPlanId']//div[1]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"click on make new extra action")]
        public void WhenClickOnMakeNewExtraAction()
        {
           driver.FindElement(By.XPath("//button[contains(text(),' Maak nieuwe persoonlijke tip ')]")).Click();
           
        }

        [When(@"user selects category")]
        public void WhenUserSelectsCategory()
        {
            driver.FindElement(By.XPath("(//option[contains(text(),'Categorie')])[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//option[@value='4'][normalize-space()='Stressbronnen (ontladers)'])[1]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user selects sources")]
        public void WhenUserSelectsSources()
        {
            driver.FindElement(By.XPath("/html[1]/body[1]/app-root[1]/app-user-tips-personal[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/span[2]/select[1]")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("(//option[@value='28'][normalize-space()='Taakonduidelijkheid'])[1]")).Click();
            Thread.Sleep(2000);

        }

        [When(@"user adds the description")]
        public void WhenUserAddsTheDescription()
        {
            driver.FindElement(By.XPath("(//textarea[@id='exampleFormControlTextarea1'])[1]")).SendKeys("adding a new tip ");
        }

        [Then(@"then user clicks on submit")]
        public void ThenThenUserClicksOnSubmit()
        {
            driver.FindElement(By.XPath("(//button[@type='button'][normalize-space()='Voeg tip toe'])[1]")).Click(); 
        }



        [Given(@"user clicks on  any plan")]
        public void GivenUserClicksOnAnyPlan()
        {
            driver.FindElement(By.XPath("//div[@id='personalPlanId']//div[1]")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"user selects a particular tip and clicks on plus icon")]
        public void ThenUserSelectsAParticularTipAndClicksOnPlusIcon()
        {
            driver.FindElement(By.XPath("(//div[contains(@class,'threeDots')])[1]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user then selects the person")]
        public void WhenUserThenSelectsThePerson()
        {
            driver.FindElement(By.XPath("//option[contains(@value,'Kies een optie')]")).Click();
            Thread.Sleep(2000);
          //  driver.FindElement(By.XPath("//option[contains(@value,'103')]")).Click();
        }

        [When(@"user selects a dedaline")]
        public void WhenUserSelectsADedaline()
        {
            driver.FindElement(By.XPath("(//input[contains(@placeholder,'Kles een datum')])[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//div[contains(text(),'December 2023')])[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//button[contains(text(),'Ok')])[1]")).Click();

        }

        [When(@"user can eneble or disable the deadline notification")]
        public void WhenUserCanEnebleOrDisableTheDeadlineNotification()
        {
            driver.FindElement(By.XPath("(//button[contains(text(),'Ok')])[1]")).Click();
           // driver.FindElement(By.XPath("(//input[contains(@id,'flexSwitchCheckDefault')])[1]")).Click();
        }

            [Then(@"user clicks on create measure")]
        public void ThenUserClicksOnCreateMeasure()
        {
            driver.FindElement(By.XPath("//div[contains(text(),' Maatregel maken ')]")).Click();
        }


    }
}
