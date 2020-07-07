using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Utils;

namespace SeleniumTest
{
    
    public class UnitTest1
    {
        private IWebDriver driver;
        private readonly string chromedriverPath = ProjectHelpers.GetProjectPath() + "Drivers";

        [Test, Description("Teste da busca do google"), Category("Smoke-Test")]
        public void MyFirstTest()
        {
            Console.WriteLine("Estou aqui!");

            
            driver = new ChromeDriver(chromedriverPath);
            driver.Navigate().GoToUrl("https://www.google.com.br");

            IWebElement txtFind = driver.FindElement(By.Name("q"));
            txtFind.SendKeys("Selenium Tuturial");
            txtFind.Submit();

            IWebElement linkText = driver.FindElement(By.XPath("//*[@id='vn1s0p1c0']/h3"));
            
            Assert.IsTrue(linkText.Text.Contains("Selenium"));

            driver.Quit();

        }

        [Test, Description("Teste da busca do google"), Category("Priority-Test")]
        public void MySecondTest()
        {
            Console.WriteLine("Estou aqui!");
            driver = new ChromeDriver(chromedriverPath);
            driver.Navigate().GoToUrl("https://www.google.com.br");

            IWebElement txtFind = driver.FindElement(By.Name("q"));
            txtFind.SendKeys("Selenium Tuturial");
            txtFind.Submit();

            IWebElement linkText = driver.FindElement(By.XPath("//*[@id='vn1s0p1c0']/h3"));

            Assert.IsTrue(linkText.Text.Contains("Selenium"));

            driver.Quit();


        }
    }
}
