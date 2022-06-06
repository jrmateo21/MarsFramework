using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Test
{
    public class ShareSkillTest

    {
        [TestFixture]

        class User : Global.Base
        {
           
            [Test]
            public void Test()
            {
                ShareSkill shareSkillPageObj = new ShareSkill();
                shareSkillPageObj.EnterShareSkill();

               

            }

           

        }



    }
}
