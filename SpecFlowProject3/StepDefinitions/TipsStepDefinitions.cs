using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.StepDefinitions
{


    [Binding]
    public class TipsStepDefinitions
    {

        IWebDriver driver;
        public IWebDriver GetDriver()
        {
            return driver;
        }
        [Given(@"navigate to ene url")]
        public void GivenNavigateToEneUrl()
        {
            driver = new ChromeDriver();


            driver.Url = "https://energie-app-dev.azurewebsites.net/nl/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

     
      

        [When(@"user  enters her/his  name")]
        public void WhenUserEntersHerHisName()
        {
            driver.FindElement(By.Id("email")).SendKeys("AvdilMulaki@mail.com");
            Thread.Sleep(2000);
        }

        [When(@"user  should enters password")]
        public void WhenUserShouldEntersPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("Ho8JLRvL41AWn07Cp1");
            Thread.Sleep(2000);
        }
           
        [Then(@"user should click on  sign in button")]
        public void ThenUserShouldClickOnSignInButton()
        {
            driver.FindElement(By.Id("next")).Click();
          
        }
        [When(@"user clicks on personal")]
        public void WhenUserClicksOnPersonal()
        {
            driver.FindElement(By.Id("persoonlijkMain")).Click();
            Thread.Sleep(3000);
        }



        [When(@"user selects the tips option")]
        public void WhenUserSelectsTheTipsOption()
        {
            driver.FindElement(By.Id("personalTipsId")).Click();
            Thread.Sleep(3000);
        }

        [When(@"then user selcts a source")]
        public void WhenThenUserSelctsASource()
        {
              driver.FindElement(By.XPath("(//div[@class=\"helpCategoryName\"])[1]")).Click();
            //driver.FindElement(By.XPath("//div[@class='helpCategoryName'][normalize-space()='Geestelijke vitaliteit']")).Click();
            //driver.FindElement(By.XPath("//div[@class='helpCategoryName'][normalize-space()='Overig']")).Click();
            Thread.Sleep(3000);
        }
        [Then(@"user favourite his/her tip")]
        public void ThenUserFavouriteHisHerTip()
        {
            driver.FindElement(By.XPath("(//i[@class=\"fa fa-star grayStar\"])[1]")).Click();
        }

  

    }
}
