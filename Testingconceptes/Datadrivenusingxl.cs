using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Terstingconceptes
{
    public  class Datadrivenusingxl
    {
        IWebDriver driver;
         public void setup()
        {
            driver= new ChromeDriver();
            driver.Url="http://uitestpractice.com/Students/Create";

            driver.Manage().Window.Maximize();
           
        }
        [Test]
        public void test()
            {
            driver.FindElement(By.Id("FirstName")).SendKeys("");
            driver.FindElement(By.Id("LastName")).SendKeys("");
            driver.FindElement(By.ClassName("text-box")).SendKeys("");
            driver.FindElement(By.ClassName("btn")).Click();
        }
        public static IEnumerable<object[]> ReadExcel()
        {
            //Create worksheet object
            using (ExcelPackage package = new ExcelPackage(new FileInfo("")))
            {
                ExcelWorksheet worksheet=package.Workbook.Worksheets["Sheet1"];


            }

        }
    }
}
