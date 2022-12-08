using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speech_To_Text.SpeechToText.POM
{
    public  class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        

        [FindsBy(How = How.Name, Using = "loginfmt")]
        public IWebElement Username;
        [FindsBy(How = How.Id, Using = "idSIButton9")]
        public IWebElement UsernameButton;
        [FindsBy(How = How.Id, Using = "i0118")]
        public IWebElement password;
        [FindsBy(How = How.Id, Using = "idSubmit_ProofUp_Redirect")]
        public IWebElement passwordButton;
        [FindsBy(How = How.CssSelector, Using = "#idSIButton9")]
        public IWebElement signButton;
        [FindsBy(How = How.ClassName, Using = "rounded-circle")]
        public IWebElement Profile;
        [FindsBy(How = How.ClassName, Using = "dropdown-item")]
        public IWebElement ProfileButton;
        [FindsBy(How = How.ClassName, Using = "btn-close")]
        public IWebElement Profileclose;


    }
    

}


