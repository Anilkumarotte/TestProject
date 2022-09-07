using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;                                                    
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Terstingconceptes
{
    public class Dropdowns1
    {           
        IWebDriver driver;
        [OneTimeSetUp]
        public void SetUptest()
        {
            driver=new ChromeDriver();
            driver.Url="https://www.hyrtutorials.com/search/label/Java";
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void test()
        {

            //IWebElement dropdown = driver.FindElement(By.LinkText("Tutorials"));
            //SelectElement objectmen = new SelectElement(dropdown);
            //IList<IWebElement> list = objectmen.Options;
            //Thread.Sleep(1000);

            //objectmen.SelectByIndex(0);
           
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.LinkText("Tutorials"))).
            ClickAndHold(driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/ul/li[2]/ul/li[4]/a"))).ClickAndHold(driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/ul/li[2]/ul/li[4]/ul/li[1]/a"))).
            Click().Perform();
            Thread.Sleep(2000);
        }
    }
}                                                                