using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POMProject.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/h1")]
        private IWebElement username;

        [FindsBy(How = How.XPath, Using = "//a[@href='/aways']")]
        private IWebElement leavePage;

        [FindsBy(How = How.XPath, Using = "//a[@href='/timesheets']")]
        private IWebElement timeSheetPage;

        [FindsBy(How = How.XPath, Using = "//a[@href='/users/sign_out']")]
        private IWebElement logout;

        public string GetUserNamefromHomePage()
        {
            return username.Text;
        }


        public TimeSheetPage GoToTimeSheetPage()
        {
            timeSheetPage.Click();
            return new TimeSheetPage(driver);

        }

        public void Logout()
        {
            logout.Click();
        }


    }
}
