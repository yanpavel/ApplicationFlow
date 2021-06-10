using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Apply
{
    public class NavigationHelper:HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            if (driver.Url == baseURL)
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL);
        }

        public void OpenPropertiesPage()
        {
            if (driver.Url == baseURL + "landlord/properties")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "landlord/properties"); 
        }

        public void OpenPropertyApplicationsPage()
        {
            if (driver.Url == baseURL + "landlord/property-applications")
            {
                return;
            }
        }
    }
}
