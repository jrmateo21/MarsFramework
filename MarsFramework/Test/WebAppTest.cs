using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;

namespace MarsFramework
{
    public class WebAppTest
    {
        

        [TestFixture]
        [Category("Sprint1")]

        class User : Global.Base
        {

           
            [Test, Order(1)]
            public void AddNewShareSkill()
            {

                ShareSkill shareSkillPageObj = new ShareSkill();
                shareSkillPageObj.EnterShareSkill();
                ManageListings manageListingsPageObj = new ManageListings();    
                string addedTitle =  manageListingsPageObj.GetLastAddedTitle();
                Console.WriteLine("Last Added Title: " + addedTitle);
                Assert.That(addedTitle == "Selenium", "Actual Title and expected title do not match");



            }

            [Test, Order(2)]
            public void ViewShareSkill()
            {
                ManageListings manageListingsPageObj = new ManageListings();              
                manageListingsPageObj.ViewListings();
                string titleToView = manageListingsPageObj.GetTitle();
                Console.WriteLine("Title: " + titleToView);
                Assert.That (titleToView == "Selenium", "Actual Title and expected title do not match");


            }


            [Test, Order(3)]
            public void EditShareSkill()
            {
                //ShareSkill shareSkillPageObj = new ShareSkill();
                //shareSkillPageObj.EditShareSkill();
                ManageListings manageListingsPageObj= new ManageListings();
                manageListingsPageObj.Listings();
                manageListingsPageObj.EditListings();
                string editedtitle = manageListingsPageObj.GetEditedTitle();
                Console.WriteLine("New Title : " + editedtitle);
                Assert.That(editedtitle == "C sharp", "Actual edited Title and expected edited title do not match");




            }

            [Test, Order(4)]
            public void DeleteShareSkillListing()
            {

                ManageListings manageListingsPageObj = new ManageListings();                
                manageListingsPageObj.DeleteListing();                
                string updatedLastTitle = manageListingsPageObj.GetLastRecord();
                Console.WriteLine("Updated Last Record :" + updatedLastTitle);
                Assert.That(updatedLastTitle != "C sharp", "Share Skill hasn't been deleted");


            }






        }
    }
}