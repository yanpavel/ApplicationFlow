using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Apply
{
    [TestFixture]
    public class AddPropertyApplication:AuthTestBase
    {
        [Test]
        public void CreatePropertyApplication()
        {
            PropertyData property = new PropertyData("Williams st");
            property.Building = "12";
            property.City = "New York";
            property.Zipcode = "54627";
            property.UnitName = "Selenium";

            app.Properties.CreateProperty(property);
            app.PropertiesApplication.CreatePropertyApplication(property);
        }
    }
}
