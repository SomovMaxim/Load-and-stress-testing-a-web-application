using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrarySOMOV3
{
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();
        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://www.amazon.com/";
            /*Assert.AreEqual("Amazon.com. Spend less. Smile more.", webDriver.Title);
            webDriver.Close();*/
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"twotabsearchtextbox\"]"));
            search.SendKeys("battery");
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div/span/input"));
            button.Click();
            IWebElement button808 = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[3]/span/div[1]/span/div/div/div[5]/ul[2]/li[4]/span/a/span"));
            button808.Click();
            IWebElement button1600 = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[3]/span/div[1]/span/div/div/div[5]/ul[3]/li[1]/span/a/span"));
            button1600.Click();
        }

        [TearDown]
        public void testEnd()
        {
            webDriver.Navigate().Refresh();
            webDriver.Quit();
        }
        
    }
}
