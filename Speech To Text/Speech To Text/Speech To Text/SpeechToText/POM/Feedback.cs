using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speech_To_Text.SpeechToText.POM
{
    public class Feedback

    {
        IWebDriver driver;
        public Feedback(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div[2]/div[2]/app-agent/div/div/div[1]/div[1]/div/div[5]/div/div/button")]
        public IWebElement Feedbackbutton;

        [FindsBy(How = How.ClassName, Using = "control-text-popup")]
        public IWebElement Tosupervisor;
        [FindsBy(How = How.ClassName, Using = "control-text-popup")]
        public IWebElement Subject;


    }
}
