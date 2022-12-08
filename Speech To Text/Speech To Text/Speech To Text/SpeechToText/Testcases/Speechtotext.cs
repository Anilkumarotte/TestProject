using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Speech_To_Text.SpeechToText.POM;

namespace Speech_To_Text.SpeechToText.Testcases
{
    public class SpeechToText:BaseClass
    {

        [Test]
        public void loginTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            LoginPage Login = new LoginPage(driver);
            
            Login.Username.SendKeys("okumar@ariqt.com");
            Login.UsernameButton.Click();
            Login.password.SendKeys("Karim@123");
            Thread.Sleep(2000);
            Login.passwordButton.Click();
            Thread.Sleep(2000);
            Login.signButton.Click();  
            Login.Profile.Click();
            Login.ProfileButton.Click();
            Login.Profileclose.Click();
        }


        [Test]
        public void FeedbackTest()//Feedbackformtest
        {
            //driver.FindElement(By.ClassName("bt-feedback-button")).Click();
            Feedback Fd = new Feedback(driver);

            Fd.Feedbackbutton.Click();

            //Fd.Tosupervisor.SendKeys("Supervisor");
            //Fd.Subject.SendKeys("Issue");
            //IWebElement list = driver.FindElement(By.ClassName("dropdown-toggle"));
            //SelectElement ChoosePrioritylist = new SelectElement(list);
            //IList<IWebElement> ChoosePriorities = ChoosePrioritylist.Options;
            //ChoosePrioritylist.SelectByText("Action");
            ////Actions action = new Actions(driver);



            //action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[1]/a/span"))).Click().Perform(); 
            //action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[1]/ul/li[1]/a"))).Click().Perform();
            //action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/app-feedback/div/div/div[2]/div/div[2]/form/div[1]/div[1]/div/select"))).
            //     Click().Perform();
            //IWebElement list = driver.FindElement(By.XPath("/html/body/app-root/app-feedback/div/div/div[2]/div/div[2]/form/div[1]/div[1]/div/select"));
            //SelectElement objectlist = new SelectElement(list);
            //IList<IWebElement> dropdownlist = objectlist.Options;
            //objectlist.SelectByIndex(2);
            //TestContext.WriteLine(dropdownlist.Count);
            //foreach (var dropdowns in dropdownlist)

            //{
            //    Console.WriteLine(dropdowns.Text);
            //}
        }
        [Test]
        public void Dashboardtest2()//Feedbackformpriority
        { 

            //Actions action = new Actions(driver);
            //action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/app-feedback/div/div/div[2]/div/div[2]/form/div[1]/div[1]/select"))).Click().Perform();
            //Thread.Sleep(2000);
            //IWebElement prioritylist = driver.FindElement(By.XPath("/html/body/app-root/app-feedback/div/div/div[2]/div/div[2]/form/div[1]/div[1]/select"));
            //SelectElement priorityobjectlist = new SelectElement(prioritylist);
            //IList<IWebElement> prioritydropdownlist = priorityobjectlist.Options;
            //priorityobjectlist.SelectByIndex(3);
            //TestContext.WriteLine(prioritydropdownlist.Count);
            //foreach (var prioritydropdowns in prioritydropdownlist)

            //{
            //    Console.WriteLine(prioritydropdowns.Text);
            //}
            //driver.FindElement(By.XPath("/html/body/app-root/app-feedback/div/div/div[2]/div/div[2]/form/div[2]/input")).SendKeys("Good");
            //driver.FindElement(By.XPath("/html/body/app-root/app-feedback/div/div/div[2]/div/div[2]/form/div[3]/textarea")).SendKeys("Good Application");
            //driver.FindElement(By.XPath("/html/body/app-root/app-feedback/div/div/div[2]/div/div[2]/form/div[4]/button")).Click();
        }
        [Test]
        public void test3() //agentandsuperiour
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.ClassName("navbar-toggler-icon"))).Click().Perform();//menu


            action.MoveToElement(driver.FindElement(By.Id("subMenu"))).Perform(); //Dashboard

            action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[1]/ul/li[2]/ul/li[1]/a/strong"))).Click().Perform(); ;//Agent
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("ms-4")).SendKeys("06/07/2022");

            action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/app-agent/div/div[1]/div/div[3]/div/div[1]/button"))).Click().Perform();

            action.MoveToElement(driver.FindElement(By.ClassName("navbar-toggler-icon"))).Click().Perform();//Menu
           
           action.ClickAndHold(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[1]/ul/li[2]/a/b"))).Perform();
           action.MoveToElement(driver.FindElement(By.Id("subMenu"))).Perform();
           action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[1]/ul/li[2]/ul/li[2]"))).Click().Perform();//Superviser

        }
        [Test]
        public void test4() //Agentlist
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.ClassName("navbar-toggler-icon"))).Click()//Menu
              .Perform();
            action.MoveToElement(driver.FindElement(By.Id("subMenu"))).Perform(); //Dashboard
            action.ClickAndHold(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[1]/ul/li[2]/ul/li[3]/a"))).Click().Perform();
          

        }
        [Test]
        public void test5() //Calllog
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.ClassName("navbar-toggler-icon"))).Click()//Menu
              .Perform();
            action.MoveToElement(driver.FindElement(By.Id("subMenu"))).Perform(); //Dashboard
           
            action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[1]/ul/li[2]/ul/li[4]/a"))).Click().Perform();
           
            
            Thread.Sleep(1000);
            // driver.FindElement(By.Id("ng-valid")).Click();
            //  driver.FindElement(By.XPath("//input[@class='ng-valid']//a[text()="+day+"]")).Click();

            //driver.FindElement(By.XPath("//table[@class='ui-datepicker-calendar']//td[not(contains(@class,'ui-datepicker-other-month'))]//a[text()="+day+"]")).Click();
            driver.FindElement(By.XPath("/html/body/app-root/app-agent-call-log/div/div[1]/form/input[1]")).SendKeys("06/07/2022");//startdate
            driver.FindElement(By.XPath("/html/body/app-root/app-agent-call-log/div/div[1]/form/input[2]")).SendKeys("19/08/2022");//end date
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement list = driver.FindElement(By.ClassName("ng-pristine"));
            SelectElement datelist = new SelectElement(list);
            IList<IWebElement> dropdownlist = datelist.Options;
            datelist.SelectByIndex(1);
            TestContext.WriteLine(dropdownlist.Count);
            foreach (var dropdowns in dropdownlist)

            {
                Console.WriteLine(dropdowns.Text);
            }
            driver.FindElement(By.ClassName("pagination-next")).Click();
            action.MoveToElement(driver.FindElement(By.ClassName("rounded-circle"))).Click().Perform();
            action.MoveToElement(driver.FindElement(By.XPath("/html/body/app-root/nav/div/li[2]/ul/a[3]"))).Click();
           // driver.FindElement(By.XPath("/html/body/div/form/div/div/div[1]/div[2]/div/div/div/div[3]/div/div/div/div/div")).Click();
        }



    }
}

