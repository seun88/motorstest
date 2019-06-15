using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Motors.MotorsHooks
{
    [Binding]
    public sealed class MotorsHooks1
    {
        
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            BaseClass.LaunchBrowser("Chrome");
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if(ScenarioContext.Current.TestError != null)
            {
                BaseClass.SaveScreenshot();
            }
            
            BaseClass.CloseBrowser();  
        }
    }
}
