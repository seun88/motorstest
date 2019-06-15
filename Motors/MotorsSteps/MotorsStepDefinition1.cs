using Motors.MotorsPages;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Motors.MotorsSteps
{
    [Binding]
    public sealed class MotorsStepDefinition1
    {
        private MotorsHomePage homepage;
        private MotorsCarListingPage CarListingPaGE;
        


        [Given(@"I navigate to Motors site")]
        public void GivenINavigateToMotorsSite()
        {
            homepage = BaseClass.GivenINavigatetoMotorsHomePage();
            homepage.AndIclickonwelcomeinfo();
            homepage.AndIAmOnMotorsHomePage();
            homepage.AndIInputpostcode();
            homepage.AndISelectCarmake();
            homepage.AndISelectCarmodel();
            homepage.AndISelectMinPrice();
            homepage.AndISelectMaxprice();
            
            
        }

        [When(@"I Input car details")]
        public void WhenIInputCarDetails()
        {
            CarListingPaGE = homepage.AndIClickSearchbutton();
            CarListingPaGE.AndIAmOnCarlistpage();
        }

        





    }
}
