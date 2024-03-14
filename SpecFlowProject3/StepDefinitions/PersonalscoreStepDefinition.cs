using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using org.w3c.dom.html;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class PersonalscoreStepDefinition
    {
        IWebDriver driver;
        public IWebDriver GetDriver()
        {
            return driver;
        }
       
        
       [Given(@"navigate to the energyapp url")]
        public void GivenNavigateToTheEnergyappUrl()
        {
            driver = new ChromeDriver();


            driver.Url = "https://energie-app-dev.azurewebsites.net/nl/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [When(@"user enters his mail")]
        public void WhenUserEntersHisMail()
        {
            driver.FindElement(By.Id("email")).SendKeys("AvdilMulaki@mail.com");
            Thread.Sleep(1000);
        }

        [When(@"user enters his pasword")]
        public void WhenUserEntersHisPasword()
        {

            driver.FindElement(By.Id("password")).SendKeys("Ho8JLRvL41AWn07Cp1");
            Thread.Sleep(1000);
        }

        [Then(@"user clicks on signin")]
        public void ThenUserClicksOnSignin()
        {
            driver.FindElement(By.Id("next")).Click();

            Thread.Sleep(2000);
        }



        [When(@"user click on personal button and score")]
        public void WhenUserClickOnPersonalButtonAndScore()
        {
            driver.FindElement(By.XPath("(//button[@id='persoonlijkMain'])[1]")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("(//div[@class='personal mt-1 mb-1 ms-2 PersonalScoresClassStyles'])[1]")).Click();
            Thread.Sleep(2000);

        }

        [When(@"After that user checks the maandscore, average ,trend and branch")]
       public void ThenAfterThatUserChecksTheMaandscoreAverageTrendAndBranch()
        {
            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[3]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[4]")).Click();
            Thread.Sleep(2000);

        }

        [When(@"user clicks on department button")]
        public void WhenUserClicksOnDepartmentButton()
        {
            driver.FindElement(By.XPath("(//button[@class='afdelingButton AfdelingChangedStyles'][normalize-space()='Afdeling'])[1]")).Click();
        }

        [When(@"user clicks on scores")]
        public void WhenUserClicksOnScores()
        {
            driver.FindElement(By.XPath("//button[@class=\"persoonlijkButton PersoonlijkStyles\"][1]")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"after users clicks on maandscore, average ,trend and branch")]
        public void ThenAfterUsersClicksOnMaandscoreAverageTrendAndBranch()
        {

            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[1]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[3]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("(//label[@class='stretched-link'])[4]")).Click();


        }

        [When(@"userr click on department")]
        public void WhenUserrClickOnDepartment()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("afdelingMain")).Click();
            Thread.Sleep(3000);
        }



        [Then(@"user clicks on analysis button")]
        public void WhenUserClicksOnAnalysisButton()
        {
           

            driver.FindElement(By.Id("afdelingAnalyseId")).Click();
        }

    

        [When(@"user click on personal")]
        public void WhenUserClickOnPersonal()
        {
            driver.FindElement(By.Id("persoonlijkMain")).Click();
            Thread.Sleep(2000);
        }

        [When(@"user click on analysis button")]
        public void WhenUserClickOnAnalysisButton()
        {
            driver.FindElement(By.Id("personalAnalysisId")).Click();
            Thread.Sleep(2000);
        }


        [When(@"user select on Stressbronne,energyborn,kwetsbaarheden and hulpbronne")]
        public void WhenUserSelectOnStressbronneEnergybornKwetsbaarhedenAndHulpbronne()
        {

           driver.FindElement(By.XPath("//button[contains(text(),' Stressbronnen ')]")).Click();
           Thread.Sleep(2000);

            driver.FindElement(By.XPath("//div[@class='card-body cardBodyContainer']//div//div//input[@value='27']")).Click();//27 to 39
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//button[contains(text(),' Energiebronnen ')]")).Click();

            driver.FindElement(By.XPath("//div[@class='card-body cardBodyContainer']//div//div//input[@value='5']")).Click();//2 to 14
            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//button[contains(text(),' Kwetsbaarheden ')]")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//div[@class='card-body cardBodyContainer']//div//div//input[@value='23']")).Click();//21 to 26
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//button[contains(text(),' Kwetsbaarheden ')]")).Click();
            Thread.Sleep(3000);



            driver.FindElement(By.XPath("//button[contains(text(),' Hulpbronnen ')]")).Click();
            Thread.Sleep(3000);


            driver.FindElement(By.XPath("//div[@class='card-body cardBodyContainer']//div//div//input[@value='17']")).Click();//15 to 20
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//button[contains(text(),' Hulpbronnen ')]")).Click();
            Thread.Sleep(3000);


        }


        [When(@"click on sla op")]
        public void WhenClickOnSlaOp()
        {
            driver.FindElement(By.XPath("(//button[@class='btn btn-primary mt-2 stressbronnenButton border border-2 rounded'])[1]")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"click on ok button")]
        public void ThenClickOnOkButton()
        {
            driver.FindElement(By.XPath("//div[@class='modal-dialog']//button[@class='btn btn-primary startAnalysisButton mb-5'][normalize-space()='OK']")).Click();


        }








    }
}

