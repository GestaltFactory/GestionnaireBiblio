using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsEmployee : ClsPerson, ITransaction
    {
        private ushort empId;
        public ushort EmpId{
            get { return empId; }
            set { empId = value; }
        }

        private EnumJobTitle jobTitle;
        public EnumJobTitle JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        private decimal salary;
        public decimal Salary{
            get { return salary; }
            set { salary = value; }
        }

        private DateTime hiringDate;
        public DateTime HiringDate{
            get { return hiringDate; }
            set { hiringDate = value; }
        }

        public ClsEmployee() : base() {

        }

        public ClsEmployee(string firstName, string lastName, ushort age, EnumSexGenre sexGenre, ushort streetNumber, string streetName, ushort appNumber, string postalCode,
                           string city, string state, string phone, string email, EnumPersonType typePerson, ushort empId, EnumJobTitle jobTitle, decimal salary, DateTime hiringDate) 
            : base(firstName, lastName, age, sexGenre, streetNumber, streetName, appNumber, postalCode, city, state, phone, email, typePerson)
        {
            this.empId = empId;
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.hiringDate = hiringDate;
        }

        public void Rent(){

        }

        public void Buy(){

        }

        public void Sell(){

        }

        public override string ToString()
        {
            return base.ToString() + "|" + empId + "|" + jobTitle + "|" + salary + "|" + hiringDate;
        }
    }
}
