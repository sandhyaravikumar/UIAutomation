using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace POMProject.PageObjects
{
    public class CreateNewTimeSheet
    {
        private IWebDriver driver;

        public CreateNewTimeSheet(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "timesheet[week]")]
        private IWebElement selectWeek;

        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement createTimesheet;

        [FindsBy(How = How.ClassName, Using = "default")]
        private IWebElement newTimeItem;

        [FindsBy(How = How.TagName, Using = "INPUT")]
        private IWebElement submit;


        private void SetWeek(string week)
        {
            SelectElement select = new SelectElement(selectWeek);
            select.SelectByValue(week);
        }

        public TimeItem CreateNewTimesheet(string week)
        {
            this.SetWeek(week);
            createTimesheet.Click();
            newTimeItem.Click();
            return new TimeItem(driver);
        }
        public void Submit()
        {
            submit.Click();
        }


    }
}