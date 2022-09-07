using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Terstingconceptes
{
    public class MouseoverActions
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver=new ChromeDriver();

            driver.Url="https://www.hyrtutorials.com/";
           // driver.Url="https://jqueryui.com/slider/#default";

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void MovetoElementTest()
        {
            Actions action = new Actions(driver);
            action
            .MoveToElement(driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/ul/li[2]/a")))
        .MoveToElement(driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/ul/li[2]/ul/li[4]/a")))
        .MoveToElement(driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/ul/li[2]/ul/li[4]/ul/li[1]/a"))).Click().Perform();

        }

        //public void Doubleclick()
        //{
        //    Actions action = new Actions(driver);

        //     IWebElement framescroll=driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[1]/div[3]/a"));//doubleclkickonbviewsourcecode

        //    // IWebElement framescroll1 = driver.FindElement(By.Id("slider"));
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;//castingourdrivertojavascriptexcuterclass using js object
        //    js.ExecuteScript("arguments[0].scrollIntoView(true);", framescroll);
        //    Thread.Sleep(5000);
        //     action.DoubleClick(framescroll).Perform();
        //    // Thread.Sleep(3000);
        //    //   ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("C:\\Users\\OtteAnilKumari(Testscreenshot\\scofrandom.png", ScreenshotImageFormat.Png);
        //    //action.ContextClick(framescroll).Perform();   
        //   // action.ClickAndHold(driver.FindElement(By.Id("slider"))).Perform();
        //}
        [TearDown]
        public void closebrowser()
        {
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            //TestContext.Progress.WriteLine();
          //  driver.Quit();
        }
    }

}



