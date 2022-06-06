using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }


        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }



        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@class='ui striped table']//tr[1]/td[8]/div/button[1]")]
        private IWebElement viewLastAddedListing { get; set; }


        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui striped table']//tr[1]/td[8]/div/button[2]")]
        private IWebElement editLastAddedListing { get; set; }



        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }


        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement currentTitle { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement editedTitle { get; set; }



        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Thread.Sleep(1000);
            manageListingsLink.Click();

        }

        internal void ViewIconListings()
        {

            Thread.Sleep(1000);
            manageListingsLink.Click();
            Thread.Sleep(1000);
            viewLastAddedListing.Click();

        }

        internal void EditIconListings()
        {
            Thread.Sleep(1000);
            manageListingsLink.Click();
            Thread.Sleep(1000);
            editLastAddedListing.Click();


        }
        internal void EditListings()
        {
            EditIconListings();
            Thread.Sleep(1000);
            editedTitle.Clear();
            editedTitle.SendKeys("Edited123");
            Thread.Sleep(1000);
            Save.Click();


        }


    }
}
