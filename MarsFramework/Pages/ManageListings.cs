using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
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

        [FindsBy(How = How.XPath, Using = "//*[@class = 'ui striped table']/tbody/tr[1]/td[8]/div/button[3]")]
        private IWebElement deleteLastAddedTilteListing { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui striped table']/tbody/tr[1]/td[3]")]
        private IWebElement updatedLastTitleListing{ get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui striped table']//tr[1]/td[8]/div/button[2]")]
        private IWebElement editLastAddedListing { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui striped table']/tbody/tr[1]/td[3]")]
        private IWebElement getLastAddedTilteListing { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'skill-title']")]
        private IWebElement getTitleInView { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui icon positive right labeled button']")]
        private IWebElement clickYesButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement currentTitle { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement editTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'ui striped table']//tr[1]/td[3]")]
        private IWebElement getEditedTitle { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement editDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'ui striped table']//tr[1]/td[4]")]
        private IWebElement editedDescription { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")]
        private IWebElement PopUpMsg { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Thread.Sleep(1000);
            manageListingsLink.Click();

        }

        internal void ViewListings()
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

            ShareSkill shareSkillPageObj = new ShareSkill();
            shareSkillPageObj.EditShareSkill();



        }


        internal void DeleteListing()
        {
            Thread.Sleep(1000);
            manageListingsLink.Click();
            Thread.Sleep(1000);
            deleteLastAddedTilteListing.Click();
            clickYesButton.Click();    
        }

        public string GetTitle()
        {
            Thread.Sleep(1000);
            return getTitleInView.Text;
        }

        public string GetLastAddedTitle()
        {
            Thread.Sleep(1000);
            return getLastAddedTilteListing.Text;
        }

        public string GetEditedTitle()
        {
            Thread.Sleep(1000);
            return getEditedTitle.Text;
        }
        public string GetLastRecord()
        {
            Thread.Sleep(2000);
            return updatedLastTitleListing.Text;
        }

        public string GetPopUpMsg()
        {
            Thread.Sleep(1000);
            return PopUpMsg.Text;
        }
    }
}

