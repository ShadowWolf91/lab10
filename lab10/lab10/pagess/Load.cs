using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.pagess
{
    class Load
    {
        protected IWebDriver driver;
        protected const int WAIT_TIMEOUT_SECONDS = 21;

        protected Load(IWebDriver driver1)
        {
            this.driver = driver1;
        }

        protected void WaitLoadedPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAIT_TIMEOUT_SECONDS);
        }
    }
}
