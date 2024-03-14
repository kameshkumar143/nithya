using java.sql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Data;
using TechTalk.SpecFlow;
using System.Linq;
using java.awt;
using System.Drawing;
using java.util.concurrent;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class CompanyStepDefinitions
    {
        IWebDriver driver;

    
    public IWebDriver GetDriver()
    {
        return driver;
    }

        [Given(@"navigate to url")]
        public void GivenNavigateToUrl()
        {
            driver = new ChromeDriver();


            driver.Url = "https://company-admin-app-dev-as.azurewebsites.net/";
          
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            


        }

        [When(@"company admin should enter username")]
        public void WhenCompanyAdminShouldEnterUsername()
        {
          driver.FindElement(By.Id("email")).SendKeys("satyaprakashpanda00@gmail.com");
            Thread.Sleep(2000);
        }

        [When(@"company admin  should enter password")]
        public void WhenCompanyAdminShouldEnterPassword()
        {
          
           driver.FindElement(By.Id("password")).SendKeys("Ay5qm5C3RfJK21PL6V");
        }

        [Then(@"click on the sign in button")]
        public void ThenClickOnTheSignInButton()
        {
             driver.FindElement(By.Id("next")).Click();
       
            Thread.Sleep(4000);

        }
       
      [When(@"navigate to add department button")]
        public void GivenNavigateToAddDepartmentButton()
        {

            IWebElement addDepts = driver.FindElement(By.XPath("//span[contains(text(), 'Add departments')]/ancestor::button"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", addDepts);


        }

        [When(@"enter new department")]
        public void WhenEnterNewDepartment()
        {
        driver.FindElement(By.Id("name")).SendKeys("physical load");
        }

        [Then(@"click on the add department")]
        public void ThenClickOnTheAddDepartment()
        {
       

        driver.FindElement(By.ClassName("clickToAddButton")).Click();   

    }

        [When(@"navigate to search department field")]
        public void GivenNavigateToSearchDepartmentField()
        {
            driver.FindElement(By.XPath("/html/body/app-root/app-company-admin/html/body/div/div[1]/form/div[2]/div[1]/div/input")).SendKeys("yoga");
        }

        [Then(@"close the app")]
        public void ThenCloseTheApp()
        {
            Thread.Sleep(4000);
            driver.Close();
        }

        [When(@"click on particular department")]
        public void WhenClickOnParticularDepartment()
        {
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("(//div[@class=\"mainButton\"])[4]")).Click();
            
        }

        [When(@"click on add user")]
        public void WhenClickOnAddUser()
        {

            driver.FindElement(By.XPath("//button[@class='btn btn-primary mb-5 me-5 addUsersButtonForLarge']")).Click();

            //driver.FindElement(By.ClassName("modal-open")).Click();

        }

        [When(@"then enter valid name")]
        public void WhenThenEnterValidName()
        {
            driver.FindElement(By.Id("name")).SendKeys("vinnela");
            Thread.Sleep(2000);
        }

        [When(@"the enter valid mailid")]
        public void WhenTheEnterValidMailid()
        {
            driver.FindElement(By.Id("email")).SendKeys("vinnela@123.com");
            Thread.Sleep(2000);
        }

        [Then(@"click on to add user")]
        public void ThenClickOnToAddUser()
        {
            driver.FindElement(By.ClassName("clickToAddButton")).Click();
            Thread.Sleep(2000);
        }



    }
}
