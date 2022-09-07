using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCart.PageObject
{
    public class Loginpage
    {
        IWebDriver driver;
        public Loginpage(IWebDriver driver)
        {
            this.driver=driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.ClassName,Using = "VJZDxU")]
        public IWebElement Username;
        [FindsBy(How = How.CssSelector,Using = "body > div._2Sn47c > div > div > div > div > div._36HLxm.col.col-3-5 > div > form > div:nth-child(2) > input")]
        public IWebElement password;
        [FindsBy(How = How.CssSelector,Using = "body > div._2Sn47c > div > div > div > div > div._36HLxm.col.col-3-5 > div > form > div._1D1L_j > button")]
        public IWebElement Button;

    }
}




//driver.FindElement(By.ClassName("VJZDxU")).SendKeys("8374145735");
//driver.FindElement(By.CssSelector("body > div._2Sn47c > div > div > div > div > div._36HLxm.col.col-3-5 > div > form > div:nth-child(2) > input")).SendKeys("123@qwe");
//driver.FindElement(By.CssSelector("body > div._2Sn47c > div > div > div > div > div._36HLxm.col.col-3-5 > div > form > div._1D1L_j > button")).Click();