using System;
using OpenQA.Selenium;
using POMProject.PageObjects;
using SeleniumExtras.PageObjects;

namespace POMProject
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement EmailId;

        [FindsBy(How = How.Id, Using = "user_password")]
        private IWebElement Password;

        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement SubmitBtn;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://kaala.herokuapp.com/");
        }

        private void SetUserName(String emailid)
        {
            EmailId.SendKeys(emailid);
        }

        private void SetPassword(String password)
        {
            Password.SendKeys(password);
        }

        private void ClickLogin(){
            SubmitBtn.Click();
        }

        public HomePage Login(String email, string pass){
            this.SetUserName(email);
            this.SetPassword(pass);
            this.ClickLogin();
            return new HomePage(driver);
        }
    }
}