using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Terstingconceptes
{
    public class multiselecteddropdown
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Multiselecteddropdown()
        {
            driver= new ChromeDriver();
            driver.Url="https://www.hyrtutorials.com/p/html-dropdown-elements-practice.html";
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Test()
        {
            IWebElement Ideelement = driver.FindElement(By.Id("ide"));
            SelectElement IdeDropdown = new SelectElement(Ideelement);
            IdeDropdown.SelectByIndex(0);
            IdeDropdown.SelectByValue("nb");
            IdeDropdown.SelectByText("Visual Studio");
            Thread.Sleep(2000);
            IdeDropdown.DeselectByValue("nb");
            

            IList<IWebElement> IdeDropdownoptions = IdeDropdown.Options;
            TestContext.Progress.WriteLine(IdeDropdownoptions.Count);

            foreach (var element in IdeDropdownoptions)
            {
                TestContext.Progress.WriteLine(element.Text);
            }
            // driver.Quit();

        }
    }
}
