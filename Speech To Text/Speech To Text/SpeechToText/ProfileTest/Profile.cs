//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using Speech_To_Text.SpeechToText.POM;
//using Speech_To_Text.SpeechToText.Testcases;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Speech_To_Text.SpeechToText.DashBoard
//{
//    public class Profile: BaseClass
//    {
      
//        [Test]
//        public void test ()
//        {
//            LoginPage Login = new LoginPage(driver);
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);


//            Actions action = new Actions(driver);
//            action.MoveToElement(driver.FindElement(By.ClassName("rounded-circle"))).Click();
//            Login.Profile.Click();
//            Login.ProfileButton.Click();
            
           

//        }
//    }
//}