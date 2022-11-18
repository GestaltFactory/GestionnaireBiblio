using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsAddress
    {
        private ushort streetNumber;
        public ushort StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        private string streetName;
        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        private ushort appNumber;
        public ushort AppNumber
        {
            get { return appNumber; }
            set { appNumber = value; }
        }

        private string postalCode;
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public ClsAddress(ushort streetNumber, string streetName, ushort appNumber, string postalCode, string city, string state)
        {
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.appNumber = appNumber;
            this.postalCode = postalCode;
            this.city = city;
            this.state = state;
        }

        public override string ToString()
        {
            return streetNumber + "|" + streetName + "|" + appNumber + "|" + postalCode + "|" + city + "|" + state;
        }
    }
}
