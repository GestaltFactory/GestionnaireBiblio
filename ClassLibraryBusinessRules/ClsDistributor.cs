using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsDistributor: ClsPerson
    {
        private ushort disId;
        public ushort DisId
        {
            get { return disId; }
            set { disId = value; }
        }

        private EnumTypeItem typeDisItem;
        public EnumTypeItem TypeDisItem
        {
            get { return typeDisItem; }
            set { typeDisItem = value; }
        }

        public ClsDistributor() : base() {

        }
        
        public ClsDistributor(string businessName, ushort streetNumber, string streetName, ushort appNumber, string postalCode,
                         string city, string state, string phone, string email, EnumPersonType typePerson, ushort disId, EnumTypeItem typeDisItem)
            : base(businessName, streetNumber, streetName, appNumber, postalCode, city, state, phone, email, typePerson)
        {
            this.disId = disId;
            this.typeDisItem = typeDisItem;
        }

        public override string Display(){
            return base.Display() + "|" + disId + "|" + typeDisItem;
        }
    }
}
