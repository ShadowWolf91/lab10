using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.pagess
{
    class PasteBinICanWin : Load
    {
        public PasteBinICanWin(IWebDriver driver) : base(driver)
        {

        }
        public PasteBinICanWin EnterSendKeyHello()
        {
            driver.FindElement(By.Id("postform-text")).SendKeys("Hello from WebDriver");
            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            return new PasteBinICanWin(driver);
        }
        public PasteBinICanWin EnterTenMin()
        {
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();
            return new PasteBinICanWin(driver);
        }

        public PasteBinICanWin EnterSendKeyWeb()
        {
            driver.FindElement(By.Id("postform-name")).SendKeys("helloweb");
            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
            return new PasteBinICanWin(driver);
        }
    }
}
