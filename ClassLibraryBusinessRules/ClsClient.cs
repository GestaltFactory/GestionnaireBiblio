using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsClient : ClsPerson, ITransaction
    {
        private ushort clientId;
        public ushort ClientId{
            get { return clientId; }
            set { clientId = value; }
        }

        private EnumClientType clientType;
        public EnumClientType ClientType{
            get { return clientType; }
            set { clientType = value; }
        }

        private string additionalInfo;
        public string AdditionalInfo{
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }

        private List<ClsClientTransaction> transaction;
        public List<ClsClientTransaction> Transaction{
            get { return transaction; }
        }

        public ClsClient() : base(){

        }

        public ClsClient(string firstName, string lastName, ushort age, EnumSexGenre sexGenre, ushort streetNumber, string streetName, ushort appNumber, string postalCode, string city,
                         string state, string phone, string email, EnumPersonType typePerson, ushort clientId, EnumClientType clientType, string additionalInfo)
            : base(firstName, lastName, age, sexGenre, streetNumber, streetName, appNumber, postalCode, city, state, phone, email, typePerson)
        {
            this.clientId = clientId;
            this.clientType = clientType;
            this.additionalInfo = additionalInfo;
        }

        public override string ToString()
        {
            return clientId + "|" + base.ToString() +"|" + clientType + "|" + additionalInfo;
        }

        public void Rent()
        {

        }

        public void Buy()
        {

        }

        public void Sell()
        {

        }
    }
}
