using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Apply
{
    public class PropertyData
    {
        public PropertyData(string address)
        {
            Address = address;
        }

        public PropertyData(string address, string building, string city, string zipcode, string unitname)
        {
            Address = address;
            Building = building;
            City = city;
            Zipcode = zipcode;
            UnitName = unitname;
        }

        public string Address { get; set; }
        public string Building { get;  set; }
        public string City { get;  set; }
        public string Zipcode { get;  set; }
        public string UnitName { get; set; }
    }
}
