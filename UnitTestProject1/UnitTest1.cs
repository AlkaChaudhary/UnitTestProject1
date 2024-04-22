using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
           
            ChromeOptions options = new ChromeOptions();
            // Path to the CEF executable.
            options.BinaryLocation=@"C:\Program Files\Stark\Sales Application\STARKSalesApplication.exe";
            // Port to communicate on. Required starting with ChromeDriver v2.41.
            options.AddArgument("remote-debugging-port=12345");
            //options.AddArgument("");

            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://beta.sales.stark.dk.aka.stark.group/");
            Thread.Sleep(5000);
            driver.FindElement(By.Name("loginfmt")).SendKeys("praveen.kumar@stark.dk");

        }
    }
}
