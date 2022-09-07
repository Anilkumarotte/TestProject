
using FlipCart.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FlipCart.Tests
{
    public class Tests 
    {
        IWebDriver driver;


        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url="https://www.flipkart.com/";
            driver.Manage().Window.Maximize();
         //   WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
        }

        
        [Test]
        public void Test1()
        {
            Loginpage page = new Loginpage(driver);
            page.Username.SendKeys("8374145735");
            page.password.SendKeys("123@qwe");
            page.Button.Click();
        }

        [Test]
        public void Test2()
        {
            Productpage page = new Productpage(driver);
            Thread.Sleep(2000);
            page.Mobiletxt.SendKeys("Mobiles");
            Thread.Sleep(2000);
            page.Serchbutton.Click();
            Thread.Sleep(2000);
            page.Clickon.Click();
            Thread.Sleep(2000);
        }
        [Test]                                            
        public void test3()
        {
           string Parentwindow = driver.CurrentWindowHandle;
            Thread.Sleep(3000);
           string ChildWindowname = driver.WindowHandles[1];  
            driver.SwitchTo().Window(ChildWindowname);
            Addcartpage page = new Addcartpage(driver);
            Thread.Sleep(3000);
            page.AddCart.Click();
            Thread.Sleep(3000);
          //  TestContext.WriteLine(page.AddCartlist.Text);
            Thread.Sleep(3000);
            page.PlaceOrderbutton.Click();
            Thread.Sleep(5000);
            page.Radiobutton.Click();
            Thread.Sleep(4000);
            page.Delevirybutton.Click();
            Thread.Sleep(4000);
            string errormsg = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div/span/text()")).Text;
            TestContext.WriteLine(errormsg);
            driver.Quit();  
        }
       

    }
}