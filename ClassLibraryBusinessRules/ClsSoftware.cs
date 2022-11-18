using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsSoftware : ClsProduct
    {
        private ushort softId;
        public ushort SoftId{
            get { return softId; }
            set { softId = value; }
        }
        
        private EnumSoftType softType;
        public EnumSoftType SoftType{
            get { return softType; }
            set { softType = value; }
        }
        
        public ClsSoftware() : base() {
            
        }

        public ClsSoftware(string productName, decimal price, ushort quantity, ClsPublisher publisher, DateTime pubDate, EnumStatus status, EnumTypeItem typeItems, ushort softId, EnumSoftType softType)
            : base(productName, price, quantity, publisher, pubDate, status, typeItems)
        {
            this.softId = softId;
            this.softType = softType;
        }

        public override string ToString(){
            return base.ToString() + "|" + softId + "|" + softType;
        }
    }
}
