using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Edit the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement editTitle { get; set; }


        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement editDescription { get; set; }


        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui form']/div[4]/div[2]//div/span[1]/a")]
        private IWebElement ClearTags { get; set; }




        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='serviceType'][@value='1']")]
        private IWebElement OneOffServiceTypeOptions { get; set; }


        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='locationType'][@value='1']")]
        private IWebElement OnSiteLocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='two wide field']//input[@index='0']")]
        private IWebElement SunDay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='two wide field']//input[@index='1']")]
        private IWebElement MonDay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='two wide field']//input[@index='2']")]
        private IWebElement TuesDay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='two wide field']//input[@index='3']")]
        private IWebElement WednesDay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='two wide field']//input[@index='4']")]
        private IWebElement ThursDay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='two wide field']//input[@index='5']")]
        private IWebElement FriDay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='two wide field']//input[@index='6']")]
        private IWebElement SaturDay { get; set; }


        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='StartTime'][@index='0']")]
        private IWebElement StartTimeSun { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='StartTime'][@index='1']")]
        private IWebElement StartTimeMon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='StartTime'][@index='2']")]
        private IWebElement StartTimeTue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='StartTime'][@index='3']")]
        private IWebElement StartTimeWed { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='StartTime'][@index='4']")]
        private IWebElement StartTimeThu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='StartTime'][@index='5']")]
        private IWebElement StartTimeFri { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='StartTime'][@index='6']")]
        private IWebElement StartTimeSat { get; set; }

        //Storing the endtime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement EndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='EndTime'][@index='0']")]
        private IWebElement EndTimeSun { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='EndTime'][@index='1']")]
        private IWebElement EndTimeMon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='EndTime'][@index='2']")]
        private IWebElement EndTimeTue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='EndTime'][@index='3']")]
        private IWebElement EndTimeWed { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='EndTime'][@index='4']")]
        private IWebElement EndTimeThu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='EndTime'][@index='5']")]
        private IWebElement EndTimeFri { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='four wide field']//input[@name='EndTime'][@index='6']")]
        private IWebElement EndTimeSat { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Click on Skill Trade option - Skill Exchange 
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades'][@value='true']")]
        private IWebElement SkillTradeOptionSE { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ui form']/div[8]/div[4]//div/span[1]/a")]
        private IWebElement ClearSkillExchange { get; set; }



        //Click on Skill Trade option - Credit
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades'][@value='false']")]
        private IWebElement SkillTradeOptionCred { get; set; }


        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        // Click Work Samples
        [FindsBy(How = How.XPath, Using = "//*[@class='huge plus circle icon padding-25']")]
        private IWebElement UploadSamplesButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='remove sign icon floatRight'][@value=0]")]
        private IWebElement ClearUploadSamplesButton { get; set; }


        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='isActive'][@value='false']")]
        private IWebElement HiddenOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void EnterShareSkill()
        {
            Thread.Sleep(1000);
            ShareSkillButton.Click();

            //Populating the excel data
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.TestDataShareSkillExcelPath, "ShareSkill");

            //Read and Enter the value from excel to Title Textbox
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            string titleAdded = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            Console.WriteLine("Title: "+ titleAdded);

            //Read and Enter the value from excel to Description Textbox
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            string descriptionAdded = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            Console.WriteLine("Description: " + descriptionAdded);

            //Category Dropdown
            CategoryDropDown.Click();
            SelectElement categorySelect = new SelectElement(CategoryDropDown);
            categorySelect.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            string  categorySelected = GlobalDefinitions.ExcelLib.ReadData(2,"Category");
            Console.WriteLine("Category: " + categorySelected);

            //Sub-Category Dropdown
            SubCategoryDropDown.Click();
            SelectElement subCategorySelect= new SelectElement(SubCategoryDropDown);
            subCategorySelect.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            string subCategorySelected = GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory");
            Console.WriteLine("Sub Category: "+ subCategorySelected);


            //Tags
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            string tagsAdded = GlobalDefinitions.ExcelLib.ReadData(2, "Tags");
            Console.WriteLine("Tags: " + tagsAdded);


            //Service type                        
            string svcTypeOption = GlobalDefinitions.ExcelLib.ReadData(2,"ServiceType");
            //Console.WriteLine(svcTypeOption);

            if (svcTypeOption == "One-off service")
                {
                    OneOffServiceTypeOptions.Click();
                    Console.WriteLine("Service Type: One-off service Selected");
                }
            else
                {
                    Console.WriteLine("Service Type: Hourly Basis Service Selected");
                }

            string locationTypeOption = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");
            //Console.WriteLine(locationTypeOption);

            if (locationTypeOption == "On-site")
                {
                    OnSiteLocationTypeOption.Click();
                    Console.WriteLine("Location Type: On-site service");

                }
            else
                {
                    Console.WriteLine("Location Type: Online service");

                }

            //Select Start Date
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            Console.WriteLine("Start Date: " + (GlobalDefinitions.ExcelLib.ReadData(2, "Startdate")));

            //Select End Date
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            Console.WriteLine("End Date: " + (GlobalDefinitions.ExcelLib.ReadData(2, "Enddate")));


            //Select Day and Time
            string selectDay = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");
            
            if (selectDay =="Mon")
                {
                    MonDay.Click();
                    Console.WriteLine("Selected Day: Monday");

                    StartTimeMon.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Starttime"));
                    string startTime = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");
                    Console.WriteLine("Start Time: " + startTime);

                    EndTimeMon.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));
                    string endTime = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
                    Console.WriteLine("End Time: " + endTime);



            }

            else if (selectDay =="Tue")
                {
                    TuesDay.Click();
                    Console.WriteLine("Selected Day: Tuesday");  
                }


            //Skill Trade and Skill Trade Text box(Skill-Exchange: Tag or  Credit: per hour)
            string  skillTradeOption = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade");          

            if (skillTradeOption == "Credit")
            {
                SkillTradeOptionCred.Click();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                Console.WriteLine("Skill Trade: " + skillTradeOption);
            }
            else
            {
                SkillTradeOptionSE.Click();
                SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
                Console.WriteLine("Skill Trade: " + skillTradeOption);
            }

            //Work Samples    
                //Option 1   - Working as well
            //Thread.Sleep(1000);
            //IWebElement uploadFile = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='selectFile'][@type='file']"));
           // uploadFile.SendKeys(Base.FileUploadPath);
           // Console.WriteLine("File to Upload: " + Base.FileUploadPath);

                //Option 2 using AutoIT
            Thread.Sleep(3000);
            UploadSamplesButton.Click();
            AutoIt.AutoItX.WinActivate("Open");
            Thread.Sleep(1000);
            AutoIt.AutoItX.Send(Base.FileUploadPath);
            Thread.Sleep(1000);
            AutoIt.AutoItX.Send("{ENTER}");




            //Active
            string activeOption = GlobalDefinitions.ExcelLib.ReadData(2, "Active");

            if (activeOption == "Hidden")
            {
                HiddenOption.Click();
                Console.WriteLine("Active Status: " + activeOption);




            }

            else
            {
                Console.WriteLine("Active Status: Active" );

            }


            Save.Click();
            Console.WriteLine("New Skills has been Created");


        }

        internal void EditShareSkill()
        {
           // ManageListings manageListingsPageObj= new ManageListings();
            //manageListingsPageObj.EditIconListings();
            
            Thread.Sleep(1000);
            editTitle.Clear();

            //Populating the excel data
            Thread.Sleep(2000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.TestDataManageListingsExcelPath, "EditShareSkill");
            editTitle.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));



            //Read and Enter the  new value from excel to Description Textbox
            editDescription.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            string descriptionAdded = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            Console.WriteLine("Description: " + descriptionAdded);

            //Category Dropdown
            CategoryDropDown.Click();
            SelectElement categorySelect = new SelectElement(CategoryDropDown);
            categorySelect.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            string categorySelected = GlobalDefinitions.ExcelLib.ReadData(2, "Category");
            Console.WriteLine("Category: " + categorySelected);

            //Sub-Category Dropdown
            SubCategoryDropDown.Click();
            SelectElement subCategorySelect = new SelectElement(SubCategoryDropDown);
            subCategorySelect.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            string subCategorySelected = GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory");
            Console.WriteLine("Sub Category: " + subCategorySelected);



            //Tags
            ClearTags.Click();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            string tagsAdded = GlobalDefinitions.ExcelLib.ReadData(2, "Tags");
            Console.WriteLine("Tags: " + tagsAdded);


            //Service type                        
            string svcTypeOption = GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType");
            //Console.WriteLine(svcTypeOption);

            if (svcTypeOption == "One-off service")
            {
                OneOffServiceTypeOptions.Click();
                Console.WriteLine("Service Type: One-off service Selected");
            }
            else
            {
                Console.WriteLine("Service Type: Hourly Basis Service Selected");
            }

            string locationTypeOption = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");
            //Console.WriteLine(locationTypeOption);

            if (locationTypeOption == "On-site")
            {
                OnSiteLocationTypeOption.Click();
                Console.WriteLine("Location Type: On-site service");

            }
            else
            {
                Console.WriteLine("Location Type: Online service");

            }

            //Select Start Date
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            Console.WriteLine("Start Date: " + (GlobalDefinitions.ExcelLib.ReadData(2, "Startdate")));

            //Select End Date
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            Console.WriteLine("End Date: " + (GlobalDefinitions.ExcelLib.ReadData(2, "Enddate")));


            //Select Day and Time
            string selectDay = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");

            if (selectDay == "Mon")
            {
                MonDay.Click();
                Thread.Sleep(1000);
                MonDay.Click();
                Console.WriteLine("Selected Day: Monday");

                StartTimeMon.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
                string startTime = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");
                Console.WriteLine("Start Time: " + startTime);

                EndTimeMon.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));
                string endTime = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
                Console.WriteLine("End Time: " + endTime);



            }

            else if (selectDay == "Tue")
            {
                TuesDay.Click();
                Thread.Sleep(1000);
                TuesDay.Click();
                Console.WriteLine("Selected Day: Tuesday");
            }


            //Skill Trade and Skill Trade Text box(Skill-Exchange: Tag or  Credit: per hour)
            string skillTradeOption = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade");

            if (skillTradeOption == "Credit")
            {
                
                SkillTradeOptionCred.Click();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                Console.WriteLine("Skill Trade: " + skillTradeOption);
            }
            else
            {                
                SkillTradeOptionSE.Click();
                ClearSkillExchange.Click();
                Thread.Sleep(1000);
                SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
                Console.WriteLine("Skill Trade: " + skillTradeOption);
            }

            //Work Samples    
            //Option 1   - Working as well
            //Thread.Sleep(1000);
            //IWebElement uploadFile = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='selectFile'][@type='file']"));
            // uploadFile.SendKeys(Base.FileUploadPath);
            // Console.WriteLine("File to Upload: " + Base.FileUploadPath);

            //Option 2 using AutoIT
            ClearUploadSamplesButton.Click();
            Thread.Sleep(3000);            
            UploadSamplesButton.Click();
            AutoIt.AutoItX.WinActivate("Open");
            Thread.Sleep(1000);
            AutoIt.AutoItX.Send(Base.FileUploadPath);
            Thread.Sleep(1000);
            AutoIt.AutoItX.Send("{ENTER}");




            //Active
            string activeOption = GlobalDefinitions.ExcelLib.ReadData(2, "Active");

            if (activeOption == "Hidden")
            {
                HiddenOption.Click();
                Console.WriteLine("Active Status: " + activeOption);




            }

            else
            {
                Console.WriteLine("Active Status: Active");

            }

            Save.Click();
            Console.WriteLine("New Skills has been Created");


        }






        



    }




}

