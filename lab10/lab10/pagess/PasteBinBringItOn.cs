using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.pagess
{
    class PasteBinBringItOn : Load
    {
        public PasteBinBringItOn(IWebDriver driver) : base(driver)
        {

        }
        public PasteBinBringItOn EnterPostformText()
        {
            driver.FindElement(By.Id("postform-text")).SendKeys("git config --global user.name  \"New Sheriff in Town\" \ngit reset $(git commit - tree HEAD ^{ tree} -m \"Legacy code\") \ngit push origin master --force");
            driver.FindElement(By.Id("select2-postform-format-container")).Click();
            return new PasteBinBringItOn(driver);
        }

        public PasteBinBringItOn EnterBash()
        {
            driver.FindElement(By.XPath("//li[text()='Bash']")).Click();
            return new PasteBinBringItOn(driver);
        }

        public PasteBinBringItOn EnterExpirationContainer()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
            return new PasteBinBringItOn(driver);
        }

        public PasteBinBringItOn EnterTenMin()
        {
            driver.FindElement(By.XPath("//li[text()='10 Minutes']")).Click();
            return new PasteBinBringItOn(driver);
        }

        public PasteBinBringItOn EnterSendKeyHowToGain()
        {
            driver.FindElement(By.Id("postform-name")).SendKeys("how to gain dominance among developers");
            driver.FindElement(By.XPath("//button[@class='btn -big']")).Click();
            return new PasteBinBringItOn(driver);
        }

        public Boolean IsSyntaxHigh()
        {
            IWebElement syntaxHighlighting = driver.FindElement(By.XPath("//a[text()='Bash']"));
            return syntaxHighlighting.Text.Contains("Bash");
        }

        public Boolean IsCodeFirstLine()
        {
            IWebElement codeFirstLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[1]/div/span[1]"));
            return codeFirstLine.Text.Contains("git config");
        }

        public Boolean IsCodeSecondLine()
        {
            IWebElement codeSecondLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[2]/div/span[1]"));
            return codeSecondLine.Text.Contains("git reset");
        }

        public Boolean IsCodeThirdLine()
        {
            IWebElement codeThirdLine = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div[2]/ol/li[3]/div/span[1]"));
            return codeThirdLine.Text.Contains("git push");
        }
    }
}
