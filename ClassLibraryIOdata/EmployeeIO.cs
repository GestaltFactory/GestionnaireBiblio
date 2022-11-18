using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryBusinessRules;

namespace ClassLibraryIOdata
{
    public class EmployeeIO
    {
        const string dir = @"";
        const string filePathEmp = dir + "Employee.txt";

        public static void SaveEmp(ClsEmployee emp, out string msg){
            StreamWriter sWriter = new StreamWriter(new FileStream(filePathEmp, FileMode.Append, FileAccess.Write));
            sWriter.WriteLine(emp.ToString());
            msg = "The Employee was created.";
            sWriter.Close();
        }

        public static List<ClsEmployee> GetListEmployee()
        {
            List<ClsEmployee> listEmp = new List<ClsEmployee>();
            StreamReader sReader = new StreamReader(filePathEmp);
            string line = sReader.ReadLine();
            while(line != null){
                ClsEmployee emp = new ClsEmployee();
                string[] field = line.Split('|');
                emp.Name = new ClsFullName(field[0], field[1]);
                emp.Age = Convert.ToUInt16(field[2]);
                emp.SexGenre = (EnumSexGenre)Enum.Parse(typeof(EnumSexGenre), field[3]);
                emp.Address = new ClsAddress(Convert.ToUInt16(field[4]), field[5], Convert.ToUInt16(field[6]), field[7], field[8], field[9]);
                emp.Phone = field[10];
                emp.Email = field[11];
                emp.EmpId = Convert.ToUInt16(field[12]);
                emp.JobTitle = (EnumJobTitle)Enum.Parse(typeof(EnumJobTitle), field[13]);
                emp.Salary = Convert.ToDecimal(field[14]);
                emp.HiringDate = Convert.ToDateTime(field[15]);
                listEmp.Add(emp);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listEmp;
        }
    }
}
