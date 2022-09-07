using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCart.PageObject
{
    public class Productpage
    {
        IWebDriver driver;
        public Productpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement Mobiletxt;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/div[2]/div[2]/form/div/button")]
        public IWebElement Serchbutton;
        [FindsBy(How = How.ClassName, Using = "_4rR01T")]
        public IWebElement Clickon;
    }
}
