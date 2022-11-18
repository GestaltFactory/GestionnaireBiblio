using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsProduct
    {
        private string productName;
        public string ProductName{
            get { return productName; }
            set { productName = value; }
        }

        private decimal price;
        public decimal Price{
            get { return price; }
            set { price = value; }
        }

        private ushort quantity;
        public ushort Quantity{
            get { return quantity; }
            set { quantity = value; }
        }

        private ClsPublisher publisher;
        public ClsPublisher Publisher{
            get { return publisher; }
            set { publisher = value; }
        }

        private DateTime pubDate;
        public DateTime PubDate
        {
            get { return pubDate; }
            set { pubDate = value; }
        }

        private EnumStatus status;
        public EnumStatus Status{
            get { return status; }
            set { status = value; }
        }

        private EnumTypeItem typeItems;
        public EnumTypeItem TypeItems{
            get { return typeItems; }
            set { typeItems = value; }
        }

        public ClsProduct(){

        }

        public ClsProduct(string productName, decimal price, ushort quantity, ClsPublisher publisher, DateTime pubDate, EnumStatus status, EnumTypeItem typeItems)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.publisher = publisher;
            this.pubDate = pubDate;
            this.status = status;
            this.typeItems = typeItems;
        }

        public override string ToString(){
            return productName + "|" + price + "|" + quantity + "|" + publisher.BusinessName + "|" + pubDate;
        }
    }
}
