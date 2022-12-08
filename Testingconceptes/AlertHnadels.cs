using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Testproject.Terstingconceptes
{
    public class AlertHandle
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void SetUp()
        {
            driver= new ChromeDriver();
           driver.Url="";

            driver.Manage().Window.Maximize();
        }

        [Test]

        public void Test()

        {
            driver.FindElement(By.XPath("/html/body/app-root/nav/div/div[3]/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("loginfmt")).SendKeys("okumar@ariqt.com");
            driver.FindElement(By.Id("idSIButton9")).Click();
            //comment
            //driver.FindElement(By.Name("B2")).Click();
            //Thread.Sleep(3000);
            //// TestContext.Progress.WriteLine(driver.FindElement(By.Name("B2")).Text);

            //driver.SwitchTo().Alert().Accept();
            //Thread.Sleep(2000);

            //driver.FindElement(By.Name("B3")).Click();

            //driver.SwitchTo().Alert().Dismiss();
            //Thread.Sleep(2000);

            //driver.SwitchTo().Alert().Accept();
            //driver.FindElement(By.Name("B4")).Click();
            //driver.SwitchTo().Alert().SendKeys("Msg");
            //Thread.Sleep(3000);
            //driver.SwitchTo().Alert().Accept();
            //Thread.Sleep(5000);
            ///c/ommkfghdth

        }
    }
}
