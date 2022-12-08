using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using lab10.pagess;
namespace lab10
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void LenovoThirdTestCase()
        {
            driver.Url = "https://www.lenovo.com/us/en/";
            driver.Manage().Window.Maximize();
            LenovoHomePage page = new LenovoHomePage(driver);
            page.EnterModel().FindModel().CompareModel();
        }
        [Test]
        public void LenovoElevenththTestCase()
        {
            driver.Url = "https://www.lenovo.com/us/en/";
            TranslateLenovoPage page = new TranslateLenovoPage(driver);
            page.EnterModel2().EnterModel3().EnterModel().CompareModel();
        }

        [Test]
        public void ICanWin()
        {
            driver.Url = "https://pastebin.com";
            driver.Manage().Window.Maximize();
            PasteBinICanWin page = new PasteBinICanWin(driver);
            page.EnterSendKeyHello().EnterTenMin().EnterSendKeyWeb();
        }

        [Test]
        public void BrightItOn()
        {
            driver.Url = "https://pastebin.com";
            driver.Manage().Window.Maximize();
            PasteBinBringItOn page = new PasteBinBringItOn(driver);
            page.EnterPostformText().EnterBash().EnterExpirationContainer().EnterTenMin().EnterSendKeyHowToGain();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            Assert.That(driver.Title, Is.EqualTo("how to gain dominance among developers - Pastebin.com"));
            Assert.IsTrue(page.IsSyntaxHigh());
            Assert.IsTrue(page.IsCodeFirstLine());
            Assert.IsTrue(page.IsCodeSecondLine());
            Assert.IsTrue(page.IsCodeThirdLine());

        }
    }
}