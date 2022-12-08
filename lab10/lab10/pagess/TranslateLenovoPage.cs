using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.pagess
{
    class TranslateLenovoPage : Load
    {
        public TranslateLenovoPage(IWebDriver driver) : base(driver)
        {

        }
        public TranslateLenovoPage EnterModel2()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/div/div[4]/div[1]/ul/li[6]/a/div/div")).Click();
            return new TranslateLenovoPage(driver);
        }
        public TranslateLenovoPage EnterModel3()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            driver.FindElement(By.XPath("/html/body/div[2]/div/button[2]")).Click();
            return new TranslateLenovoPage(driver);
        }
        public TranslateLenovoPage EnterModel()
        {
            driver.Url = "https://www.lenovo.com/ru/ru/privacy/";
            driver.Manage().Window.Maximize();
            return new TranslateLenovoPage(driver);
        }


        public TranslateLenovoPage FindModel()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div[1]/p[2]")).Click();
            return new TranslateLenovoPage(driver);
        }
        public TranslateLenovoPage CompareModel()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            string productPrivacy = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/h1[2]")).GetAttribute("innerText");
            Assert.That(productPrivacy, Is.EqualTo("Положение о конфиденциальности продукции Lenovo"));
            return new TranslateLenovoPage(driver);
        }
    }
}
