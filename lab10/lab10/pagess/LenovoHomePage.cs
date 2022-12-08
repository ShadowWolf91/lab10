using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.pagess
{
    class LenovoHomePage : Load
    {
        public LenovoHomePage(IWebDriver driver) : base(driver)
        {

        }
        public LenovoHomePage EnterModel()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/div/div/div/div[4]/div[1]/div/form/input[1]")).SendKeys("Yoga 6");
            return new LenovoHomePage(driver);
        }

        public LenovoHomePage FindModel()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/div/div/div/div[4]/div[1]/div/span")).Click();
            return new LenovoHomePage(driver);
        }
        public LenovoHomePage CompareModel()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            string findYoga = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div[2]/div[3]/ul/li[2]/div[4]/a")).GetAttribute("innerText");
            Assert.That(findYoga, Is.EqualTo("Yoga 6 (13” AMD) - Dark Teal with Aluminum Top Cover"));
            return new LenovoHomePage(driver);
        }
    }
}
