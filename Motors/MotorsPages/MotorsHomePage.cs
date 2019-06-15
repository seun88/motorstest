using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Motors.MotorsPages
{
    public class MotorsHomePage : BaseClass
    {
        private IWebElement Welcomeinfo;
        private IWebElement logo;
        private IWebElement postcode;
        private IWebElement Carmake;
        private IWebElement Carmodel;
        private IWebElement Minprice;
        private IWebElement Maxprice;
        private IWebElement Searchcarbutton;

        public void AndIclickonwelcomeinfo()
        {
            Welcomeinfo = GetElementByXpath("/ html / body / div[5] / div[1] / div[2] / div / div / div[2] / div[1] / a");
            Welcomeinfo.Click();
        }

        public void AndIAmOnMotorsHomePage()
        {
            logo = GetElementByClassName("logo");
            Assert.True(logo.Displayed, "is not displayed");
        }

        public void AndIInputpostcode()
        {
            postcode = GetElementByClassName("postcode");
            Actions actions = new Actions(driver);
            actions.MoveToElement(postcode);
            actions.Click();
            actions.SendKeys("M73TT");
            actions.Build().Perform();
        }

        

        public void AndISelectCarmake()
        {
            Carmake = GetElementById("Make");
            SelectByValue(Carmake, "Audi");
        }

        

        public void AndISelectCarmodel()
        {
            Carmodel = GetElementById("Model");
            SelectByValue(Carmodel, "A1");
        }

        public void AndISelectMinPrice()
        {
            Minprice = GetElementById("MinPrice");
            SelectByValue(Minprice, "1");

        }

        public void AndISelectMaxprice()
        {
            Maxprice = GetElementById("MaxPrice");
            SelectByValue(Maxprice, "20000");
        }

        public MotorsCarListingPage AndIClickSearchbutton()
        {
            Searchcarbutton = GetElementByCssSelector(".btn.sp__btn");
            Searchcarbutton.Click();
 

            return new MotorsCarListingPage();

 

        }


    }
}
