using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCart.PageObject
{
    public class Addcartpage 
    {

        IWebDriver driver;

        public Addcartpage(IWebDriver driver)//Constructer (It accepts the webdriver objects
        {
            this.driver=driver;
            PageFactory.InitElements(driver,this);  
       
       }
        [FindsBy(How = How.XPath, Using ="//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")]
        public IWebElement AddCart;
        [FindsBy(How = How.ClassName, Using = "_3g_HeN")]
        public IWebElement AddCartlist;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div[1]/div[1]/div/div[11]/div/form/button")]
        public IWebElement PlaceOrderbutton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div/div[3]/button[2]")]
        public IWebElement Radiobutton;
        [FindsBy(How = How.ClassName, Using = "RLM7ES")]
        public IWebElement Delevirybutton;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label[1]/div[2]/div/div[1]/button")]
        public IWebElement Placeorderbutton;

        
    }
}

