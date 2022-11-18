using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsPerson
    {
        private string businessName;
        public string BusinessName{
            get { return businessName; }
            set { businessName = value; }
        }
        
        private ClsFullName name;
        public ClsFullName Name{
            get { return name; }
            set { name = value; }
        }

        private EnumSexGenre sexGenre;
        public EnumSexGenre SexGenre{
            get { return sexGenre; }
            set { sexGenre = value; }
        }

        private ushort age;
        public ushort Age{
            get { return age; }
            set { age = value; }
        }

        private ClsAddress address;
        public ClsAddress Address{
            get { return address; }
            set { address = value; }
        }

        private string phone;
        public string Phone{
            get { return phone; }
            set { phone = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private EnumPersonType typePerson;
        public EnumPersonType TypePerson{
            get { return typePerson; }
            set { typePerson = value; }
        }

        public ClsPerson(){

        }

        public ClsPerson(string businessName, ushort streetNumber, string streetName, ushort appNumber, string postalCode, 
                         string city, string state, string phone, string email, EnumPersonType typePerson)
        {
            address = new ClsAddress(streetNumber, streetName, appNumber, postalCode, city, state);
            this.phone = phone;
            this.email = email;
            this.typePerson = typePerson;
        }

        public ClsPerson(string firstName, string lastName, ushort age, EnumSexGenre sexGenre, ushort streetNumber, string streetName, ushort appNumber, string postalCode,
                 string city, string state, string phone, string email, EnumPersonType typePerson)
        {
            name = new ClsFullName(firstName, lastName);
            this.sexGenre = sexGenre;
            this.age = age;
            address = new ClsAddress(streetNumber, streetName, appNumber, postalCode, city, state);
            this.phone = phone;
            this.email = email;
            this.typePerson = typePerson;
        }

        public override string ToString()
        {
            return name.ToString() + "|" + age + "|" + sexGenre + "|" + address.ToString() + "|" + phone + "|" + email;
        }

        public virtual string Display(){
            return businessName + "|" + address.ToString() + "|" + phone + "|" + email;
        }
    }
}
