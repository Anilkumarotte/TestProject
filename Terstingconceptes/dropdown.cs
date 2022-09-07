using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Testproject.Terstingconceptes
{
    public class DropDown
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void SetUp()
        {
            driver= new ChromeDriver();
            driver.Url="https://www.facebook.com/r.php?locale=en_GB";

            driver.Manage().Window.Maximize();
        }
        [Test]
        public void DropdownTest()
        {
            Thread.Sleep(2000);

            IWebElement Dates = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[2]/div/div/div[1]/form/div[1]/div[5]/div[2]/span/span/select[1]"));

            SelectElement objectmen = new SelectElement(Dates);
            // bool Fals = SelectElement.IsMultiple;

            IList<IWebElement> list = objectmen.Options;//optionproperty
            TestContext.WriteLine(list.Count);
            foreach (var Date in list)

            {
                Console.WriteLine(Date.Text);
            }
            Thread.Sleep(2000);
            objectmen.SelectByIndex(0);
            objectmen.SelectByText("15");
            objectmen.SelectByValue("17");














        }
    }
}
