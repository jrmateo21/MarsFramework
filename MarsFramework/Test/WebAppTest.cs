using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

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
               
            }



        }
    }
}