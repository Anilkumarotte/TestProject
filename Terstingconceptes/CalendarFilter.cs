using NPOI.SS.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Terstingconceptes
{
    public class CalendarFilter
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver=new ChromeDriver();

            driver.Url="https://www.hyrtutorials.com/p/calendar-practice.html";
            

            driver.Manage().Window.Maximize();
        }
        [Test]
        public void calandartset()
        {
            int day = 1;
            //Firstcalandar
            Thread.Sleep(1000);
            driver.FindElement(By.Id("first_date_picker")).Click();
           driver.FindElement(By.XPath("//table[@class='ui-datepicker-calendar']//a[text()="+day+"]")).Click();
            Thread.Sleep(1000);
            //secondcalandar
            driver.FindElement(By.Id("second_date_picker")).Click();
           Thread.Sleep(1000); 
            driver.FindElement(By.XPath("//table[@class='ui-datepicker-calendar']//td[not(contains(@class,'ui-datepicker-other-month'))]//a[text()="+day+"]")).Click();
           // String targerdate = "07/July//2022";
           // SimpleDateFormat targetdate =new SimpleDateFormat();

        }


    }
}
