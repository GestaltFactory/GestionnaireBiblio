using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsOrder
    {
        private ushort orderId;
        public ushort OrderId{
            get { return orderId; }
            set { orderId = value; }
        }

        private ClsFullName orderedBy;
        public ClsFullName OrderedBy{
            get { return orderedBy; }
            set { orderedBy = value; }
        }

        private string productName;
        public string ProductName{
            get { return productName; }
            set { productName = value; }
        }

        private string productDesc;
        public string ProductDesc{
            get { return productDesc; }
            set { productDesc = value; }
        }

        private decimal productPrice;
        public decimal ProductPrice{
            get { return productPrice; }
            set { productPrice = value; }
        }

        private ushort productQuantity;
        public ushort ProductQuantity{
            get { return productQuantity; }
            set { productQuantity = value; }
        }

        private DateTime orderDate;
        public DateTime OrderDate{
            get { return orderDate; }
            set { orderDate = value; }
        }

        private string distributorName;
        public string DistributorName{
            get { return distributorName; }
            set { distributorName = value; }
        }
    }
}
