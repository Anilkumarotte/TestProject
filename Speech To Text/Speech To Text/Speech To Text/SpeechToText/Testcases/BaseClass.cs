using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Speech_To_Text.SpeechToText.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speech_To_Text.SpeechToText.Testcases
{
  public class BaseClass
    {
       public IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver= new ChromeDriver();
            driver.Url= "https://speechtotextdashboard.azurewebsites.net/";
            driver.FindElement(By.ClassName("text-white")).Click();
            driver.Manage().Window.Maximize();

        }

        //[Test]
        //public void loginTest()
        //{
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

        //    LoginPage Login = new LoginPage(driver);
        //    Login.LoginButton.Click();
        //    Login.Username.SendKeys("okumar@ariqt.com");
        //    Login.UsernameButton.Click();
        //    Login.password.SendKeys("Karim@123");
        //    Thread.Sleep(2000);
        //    Login.passwordButton.Click();
        //    Thread.Sleep(2000);
        //    Login.signButton.Click();
        //    Login.Profile.Click();
        //    Login.ProfileButton.Click();
        //}

        //[OnetTearDown]
        //public void Aftertest()
        //{

        //  TestContext.WriteLine(driver.Title);



        //   driver.Quit();
        //}
    }
}
