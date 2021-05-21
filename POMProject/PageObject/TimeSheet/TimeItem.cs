using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace POMProject.PageObjects
{
    public class TimeItem
    {
        private IWebDriver driver;

        public TimeItem(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "timeitem[project_id]")]
        private IWebElement selectProject;

        [FindsBy(How = How.Id, Using = "timeitem_mon")]
        private IWebElement monday;

        [FindsBy(How = How.Id, Using = "timeitem_tue")]
        private IWebElement tuesday;

        [FindsBy(How = How.Id, Using = "timeitem_wed")]
        private IWebElement wednesday;

        [FindsBy(How = How.Id, Using = "timeitem_thu")]
        private IWebElement thursday;

        [FindsBy(How = How.Id, Using = "timeitem_fri")]
        private IWebElement friday;

        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement createTimeItem;

        private void SetProject(String option)
        {
            SelectElement select = new SelectElement(selectProject);
            select.SelectByText(option);
        }

        private void SetMondayWorkingHours(string time)
        {
            monday.SendKeys(time);
        }

        private void SetTuesdayWorkingHours(string time)
        {
            tuesday.SendKeys(time);
        }

        private void SetWednesdayWorkingHours(string time)
        {
            wednesday.SendKeys(time);
        }

        private void SetThursdayWorkingHours(string time)
        {
            thursday.SendKeys(time);
        }
        private void SetFridayWorkingHours(string time)
        {
            friday.SendKeys(time);
        }

        public void SetTime(string option, string time)
        {
            this.SetProject(option);
            this.SetMondayWorkingHours(time);
            this.SetTuesdayWorkingHours(time);
            this.SetWednesdayWorkingHours(time);
            this.SetThursdayWorkingHours(time);
            this.SetFridayWorkingHours(time);
            createTimeItem.Click();
        }

    }
}