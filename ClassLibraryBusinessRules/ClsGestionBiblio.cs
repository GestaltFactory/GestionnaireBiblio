using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsGestionBiblio
    {
        private ClsClient client;
        public ClsClient Client{
            get { return client; }
            set { client = value; }
        }

        private ClsProduct product;
        public ClsProduct Product{
            get { return product; }
            set { product = value; }
        }

        private ClsOrder order;
        public ClsOrder Order{
            get { return order; }
            set { order = value; }
        }

        private DateTime schedule;
        public DateTime Schedule{
            get { return schedule; }
            set { schedule = value; }
        }

        public ClsGestionBiblio(string firstName, string lastName, ushort age, /*EnumSexGenre sexGenre, */ushort streetNumber, string streetName, ushort appNumber, 
                                string postalCode, string city, string state, string phone, string email, /*ushort clientId EnumClientType clientType*/ string addInfo)
        {

        }
    }
}
