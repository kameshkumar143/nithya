           using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]

    public class SuperAdminTipStepDefinition
    {
     

        IWebDriver driver;

        public IWebDriver GetDriver()
        {
            return driver;
        }
        [Given(@"navigate to the superadmin url")]
        public void GivenNavigateToUrl()
        {
            driver = new ChromeDriver();


            driver.Url = " https://energie-superadmin-dev.azurewebsites.net/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [When(@"user should a enter the mail")]
        public void WhenUserShouldAEnterTheMail()
        {
            driver.FindElement(By.Id("i0116")).SendKeys("dnithya@ariqt.com");
            Thread.Sleep(2000);
        }

        [When(@"user should  a click on next")]
        public void WhenUserShouldAClickOnNext()
        {
            driver.FindElement(By.Id("idSIButton9")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user should  a enter the password")]
        public void WhenUserShouldAEnterThePassword()
        {
            driver.FindElement(By.Id("i0118")).SendKeys("Surya1@vardhan");
            Thread.Sleep(2000);
        }

        [When(@"user should click  signin button")]
        public void WhenUserShouldClickSigninButton()
        {
            driver.FindElement(By.XPath("//input[@value=\"Sign in\"]")).Click();

        }

        [Then(@"user either selects  a yes or no")]
        public void ThenUserEitherSelectsAYesOrNo()
        {
            driver.FindElement(By.Id("idBtn_Back")).Click();
        }



        [When(@"click on the addtip field")]

        public void GivenClickOnTheAddtipField()
        {
            driver.FindElement(By.XPath("/html/body/app-root/app-sign-up/div[2]/div[2]/div[1]/span[1]/button")).Click();
            Thread.Sleep(4000);
        }
    
          [When(@"then click on category")]
        public void WhenThenClickOnCategory()
        {
         
            driver.FindElement(By.XPath("//option[@value=\"Sources\"]")).Click();
            Thread.Sleep(2000);
        }
        [When(@"select on any category")]
        public void WhenSelectOnAnyCategory()
        {
            driver.FindElement(By.XPath("//option[@value=\"3\"]")).Click();//1,2,3,4
            Thread.Sleep(2000);
        }

        [When(@"then click on source")]
        public void WhenThenClickOnSource()
        {
          driver.FindElement(By.XPath("//option[@value=\"Categories\"]")).Click();
            Thread.Sleep(2000);

        }
        [When(@"select on any sources")]
        public void WhenSelectOnAnySources()
        {
             driver.FindElement(By.XPath("//option[@value=\"21\"]")).Click();//79 to 116
            Thread.Sleep(2000);
            
        }


        [When(@"after that enter a title")]
        public void WhenAfterThatEnterATitle()
        {
            driver.FindElement(By.XPath("//input[@type=\"text\"]")).SendKeys("load perform");
            Thread.Sleep(2000);
        }

        [When(@"then enter a description")]
        public void WhenThenEnterADescription()
        {
            driver.FindElement(By.Id("exampleFormControlTextarea1")).SendKeys("load perform desc");
            Thread.Sleep(2000);
        }


        [Then(@"click on submit")]
        public void ThenClickOnSubmit()
        {
            driver.FindElement(By.XPath("//button[@class=\"submitButton bg-btn-primary-gradient\"]")).Click();
        }

        [When(@"click on Department field")]
        public void WhenClickOnDepartmentField()
        {
            driver.FindElement(By.ClassName("afdelingButton")).Click();
            Thread.Sleep(2000);
        }


        [When(@"click on the Department addtip field")]
        public void WhenClickOnTheDepartmentAddtipField()
        {
            driver.FindElement(By.XPath("/html/body/app-root/app-sign-up/div[2]/div[2]/div[1]/span[1]/button")).Click();
            Thread.Sleep(2000);
        }

        [When(@"then click on  Department category")]
        public void WhenThenClickOnDepartmentCategory()
        {
            driver.FindElement(By.XPath("//option[@value=\"Sources\"]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"select on any  Department category")]
        public void WhenSelectOnAnyDepartmentCategory()
        {
            driver.FindElement(By.XPath("//option[@value=\"3\"]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"then click on  Department source")]
        public void WhenThenClickOnDepartmentSource()
        {
            driver.FindElement(By.XPath("//option[@value=\"Categories\"]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"select on any  Department sources")]
        public void WhenSelectOnAnyDepartmentSources()
        {
            driver.FindElement(By.XPath("//option[@value=\"21\"]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"after that enter a  Department title")]
        public void WhenAfterThatEnterADepartmentTitle()
        {
            driver.FindElement(By.XPath("//input[@type=\"text\"]")).SendKeys("load perform");
            Thread.Sleep(2000);
        }

        [When(@"then enter a  Department description")]
        public void WhenThenEnterADepartmentDescription()
        {
            driver.FindElement(By.Id("exampleFormControlTextarea1")).SendKeys("load perform desc");
            Thread.Sleep(2000);
        }

        [Then(@"click on  Department submit")]
        public void ThenClickOnDepartmentSubmit()
        {
            driver.FindElement(By.XPath("//button[@class=\"submitButton bg-btn-primary-gradient\"]")).Click();
        }
        


    }
}
