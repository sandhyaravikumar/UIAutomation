using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace POMProject.PageObjects
{
    public class TimeSheetPage
    {
        private IWebDriver driver;

        public TimeSheetPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/timesheets/new']")]

        private IWebElement createTimesheet;

        public CreateNewTimeSheet CreateNewTimeSheet()
        {
            createTimesheet.Click();
            return new CreateNewTimeSheet(driver);
        }

    }
}