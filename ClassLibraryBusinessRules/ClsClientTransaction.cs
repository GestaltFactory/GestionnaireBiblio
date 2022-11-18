using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsClientTransaction
    {
        private ushort transactionId;
        public ushort TransactionId{
            get { return transactionId; }
            set { transactionId = value; }
        }

        private ClsFullName rentedBy;
        public ClsFullName RentedBy{
            get { return rentedBy; }
            set { rentedBy = value; }
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

        private ushort quantityRented;
        public ushort QuantityRented{
            get { return quantityRented; }
            set { quantityRented = value; }
        }

        private DateTime rentedDate;
        public DateTime RentedDate{
            get { return rentedDate; }
            set { rentedDate = value; }
        }
    }
}
