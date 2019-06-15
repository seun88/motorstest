using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Motors.MotorsPages
{
    public class MotorsCarListingPage : BaseClass
    {
        private IList<IWebElement> carlist;
        


        public void AndIAmOnCarlistpage()
        {
            carlist = GetElementsByClassName("title");
            Assert.True(carlist.Count > 0, "not on listing page");
        }

        







    }



}

