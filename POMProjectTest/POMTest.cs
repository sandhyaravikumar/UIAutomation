using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using POMProject.PageObjects;
using POMProject;

namespace POMProjectTest
{
    public class POMTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void UserLoginValidation()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.GoToPage();
            HomePage home = loginpage.Login("sandhyar@testvagrant.com", "password");
            string username = home.GetUserNamefromHomePage();
            Assert.AreEqual("Sandhya Ravikumar", username);
            home.Logout();

        }
        [Test]
        public void CreatingNewTimeSheet()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.GoToPage();

            HomePage home = loginpage.Login("sandhyar@testvagrant.com", "password");
            string username = home.GetUserNamefromHomePage();
            Assert.AreEqual("Sandhya Ravikumar", username);

            TimeSheetPage timeSheetPage = home.GoToTimeSheetPage();
            CreateNewTimeSheet newTimeSheet = timeSheetPage.CreateNewTimeSheet();

            TimeItem timeItem = newTimeSheet.CreateNewTimesheet("07 June, 2021");
            timeItem.SetTime("Beach", "8");
            newTimeSheet.Submit();

            home.Logout();
        }


        [TearDown]

        public void TearDown()
        {
            driver.Close();
        }
    }
}