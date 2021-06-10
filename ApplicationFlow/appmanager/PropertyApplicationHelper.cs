using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Apply
{
    public class PropertyApplicationHelper:HelperBase
    {
        public PropertyApplicationHelper(ApplicationManager manager) : base(manager)
        {
        }

        public PropertyApplicationHelper CreatePropertyApplication(PropertyData property)
        {
            manager.Navigator.OpenPropertiesPage();
            SearchProperty();
            SearchThisTypeOfProperty();
            SearchThisName(property);
            OpenActionsList();
            ListProperty();
            FillApplicationRequestForm();
            SelectAllChecboxes_CreatePA();
            NextPage_CreatePA();
            SelectAllChecboxes_CreatePA();
            NextPage_CreatePA();
            SelectAllChecboxes_CreatePA();
            NextPage_CreatePA();
            SelectAllChecboxes_CreatePA();
            NextPage_CreatePA();
            SelectAllChecboxes_CreatePA();
            NextPage_CreatePA();
            SelectAllChecboxes_CreatePA();
            NextPage_CreatePA();
            Submit_CreatePA();
            return this;
        }

        private PropertyApplicationHelper Submit_CreatePA()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            return this;
        }

        private PropertyApplicationHelper NextPage_CreatePA()
        {
            driver.FindElement(By.XPath("//button[2]/span")).Click();
            return this;
        }

        private PropertyApplicationHelper SelectAllChecboxes_CreatePA()
        {
            driver.FindElement(By.XPath("//mat-list-option/div/div[2]")).Click();
            return this;

        }

        private PropertyApplicationHelper FillApplicationRequestForm()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("mat-input-0")));
            Type(By.Id("mat-input-0"), "list@autotest.ru");
            Type(By.Id("mat-input-1"), "list@autotest.ru");
            Type(By.Id("mat-input-2"), "(182) 712-7361");
            driver.FindElement(By.XPath("//mat-checkbox[@id='mat-checkbox-1-input']/label")).Click();
            Type(By.Id("mat-input-3"), "1000");
            Type(By.Id("mat-input-4"), "1000");
            Type(By.Id("mat-input-5"), "3");
            Type(By.Id("mat-input-6"), "4");
            Type(By.Id("mat-input-7"), "100");
            Type(By.Id("mat-input-8"), "Description");
            driver.FindElement(By.CssSelector(".button")).Click();
           
            return this;
        }

        private PropertyApplicationHelper SearchThisName(PropertyData property)
        {
            Type(By.Id("mat-input-0"), ""+property.UnitName+"");
            driver.FindElement(By.Id("mat-input-0")).SendKeys(Keys.Enter);
            return this;
        }

        private PropertyApplicationHelper ListProperty()
        {
            driver.FindElement(By.CssSelector("button.mat-menu-item:nth-child(4)")).Click();
            driver.FindElement(By.XPath("//mat-dialog-container[@id='mat-dialog-0']/app-confirmation/div/div[3]/button/span")).Click();
            return this;
        }

        private PropertyApplicationHelper OpenActionsList()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//td[7]/button/span/mat-icon")));
            driver.FindElement(By.XPath("//td[7]/button/span/mat-icon")).Click();
            return this;
        }

        private PropertyApplicationHelper SearchThisTypeOfProperty()
        {
            driver.FindElement(By.XPath("//mat-option[@id='mat-option-0']/span")).Click();
            return this;
        }

        private PropertyApplicationHelper SearchProperty()
        {
            driver.FindElement(By.Id("mat-chip-list-input-0")).Click();
            return this;

        }
    }
}
