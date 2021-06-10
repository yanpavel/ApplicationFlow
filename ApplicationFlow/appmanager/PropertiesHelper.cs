using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Apply
{
    public class PropertiesHelper:HelperBase
    {


        public PropertiesHelper(ApplicationManager manager) : base(manager)
        {
        }

        public PropertiesHelper CreateProperty(PropertyData property)
        {
            manager.Navigator.OpenPropertiesPage();
            OpenPropertyForm();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            TypePropertyAddress(property);
            SelectPropertyType(1);
            SubmitPropertyAddress();
            FillUnitForm(property);
            SubmitPropertyCreation();
            return this;
        }

        public PropertiesHelper SubmitPropertyCreation()
        {
            driver.FindElement(By.XPath("//button[2]/span")).Click();
            return this;
        }

        public PropertiesHelper FillUnitForm(PropertyData property)
        {
            Type(By.Id("mat-input-5"),property.UnitName);
            return this;
        }

        public PropertiesHelper SubmitPropertyAddress()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            return this;
        }

        public PropertiesHelper TypePropertyAddress(PropertyData property)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("mat-input-1")));
            Type(By.Id("mat-input-1"), property.Address);
            Type(By.Id("mat-input-2"), property.Building);
            Type(By.Id("mat-input-3"), property.City);
            SelectState(1);
            Type(By.Id("mat-input-4"), property.Zipcode); ;
            return this;
        }

        public PropertiesHelper SelectState(int index)
        {
            driver.FindElement(By.XPath("//mat-select[@id='mat-select-1']/div/div/span")).Click();
            driver.FindElement(By.XPath("//mat-option[@id='mat-option-" + index + 8 + "']/span")).Click();
            return this;
        }

        public PropertiesHelper OpenPropertyForm()
        {
            driver.FindElement(By.XPath("//button[3]/span/mat-icon")).Click();
            return this;
        }

        public PropertiesHelper SelectPropertyType(int index)
        {
            driver.FindElement(By.XPath("//mat-radio-button[@id='mat-radio-"+ (index+1)+"']/label/div[2]")).Click();
            return this;
        }

      
       
        
        
       
    }
}

