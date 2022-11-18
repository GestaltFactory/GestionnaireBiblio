using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsFullName
    {
        private string firstName;
        public string FirstName{
            get { return firstName; }
            set { firstName = value.Substring(0, 1).ToUpper() + value.Trim().Remove(0, 1).ToLower(); }
        }

        private string lastName;
        public string LastName{
            get { return lastName; }
            set { lastName = value.Substring(0, 1).ToUpper() + value.Trim().Remove(0, 1).ToLower(); }
        }

        public ClsFullName(string fn, string ln){
            firstName = fn;
            lastName = ln;
        }

        public override string ToString(){
            return firstName + "|" + lastName;
        }
    }
}