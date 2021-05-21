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

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/table")]
        private IWebElement weektable;
        
        public TimeSheet CreateNewTimeSheet()
        {
            createTimesheet.Click();
            return new TimeSheet(driver);
        }

        public TimeSheet ModifyTimeSheet(string date)
        {
            weektable.FindElement(By.LinkText(date)).Click();
            return new TimeSheet(driver);
        }

    }
}