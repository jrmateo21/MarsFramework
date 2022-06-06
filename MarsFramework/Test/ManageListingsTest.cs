using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MarsFramework.Pages;

namespace MarsFramework.Test
{
    public  class ManageListingsTest
    {
        [TestFixture]

        class User : Global.Base
        {

             [Test]
           
            public void ManageListingLink() //TC_001_01
            {
                ManageListings manageListingsPageObj = new ManageListings();
                manageListingsPageObj.Listings();
                Console.WriteLine("TC_001_01 , Passed!  You were able to click the Manage Listing via HomePage");
            }

            [Test]

            public void ManageListingView() //TC_002_01
            {
                ManageListings manageListingsPageObj = new ManageListings();
                manageListingsPageObj.Listings();
                Console.WriteLine("TC_002_01 , Passed!  You can now  view Manage Listing Page");
            }



            [Test]

            public void ViewListingsTest() //TC_003_01
            {
                ManageListings manageListingsPageObj = new ManageListings();
                manageListingsPageObj.ViewIconListings();

                Console.WriteLine("TC_003_01 , Passed!  You were able to click the view eye icon");
            }

            [Test]

            public void ViewListingsResultTest() //TC_003_02
            {
                ManageListings manageListingsPageObj = new ManageListings();
                manageListingsPageObj.ViewIconListings();

                Console.WriteLine("TC_003_02 , Passed!  You were able to   view using   view eye icon");
            }

            [Test]

            public void EditListingsTest() //TC_004_01
            {
                ManageListings manageListingsPageObj = new ManageListings();
                manageListingsPageObj.EditIconListings();
                Console.WriteLine("TC_004_001 , Passed!  you were able to click the Edit  icon");
            }

            [Test]
            public void EditListingsResultTest() //TC_004_02
            {
                ManageListings manageListingsPageObj = new ManageListings();
                
                manageListingsPageObj.EditListings();
                Console.WriteLine("TC_004_002 , Passed!  you were able to click the Edit  icon");
            }










        }

    }
}
