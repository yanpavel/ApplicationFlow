using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Apply
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager)
       : base(manager)
        {

        }
        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                Logout();
            }
            Type(By.Id("mat-input-0"), account.Username);
            Type(By.Id("mat-input-1"), account.Password);
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            SelectRole();

        }


        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.XPath("//a[7]/div/span")).Click();

            }
        }

        public void SelectRole()
        {
            if (HasRole())
            {
                driver.FindElement(By.XPath("//button[2]/span")).Click();
            }
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.XPath("//a[7]/div/span"));
        }
        public bool HasRole()
        {
            return IsElementPresent(By.XPath("//button[2]/span"));
        }
        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                && GetLoggedUsername() == account.Username;


        }

        public string GetLoggedUsername()
        {
            string text = driver.FindElement(By.XPath("//strong")).Text;
            return text.Substring(1, text.Length);
        }
    }
}
