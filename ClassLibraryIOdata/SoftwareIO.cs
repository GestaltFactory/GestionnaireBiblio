using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryBusinessRules;

namespace ClassLibraryIOdata
{
    public class SoftwareIO
    {
        const string dir = @"";
        const string filePathSoftware = dir + "Software.txt";

        public static void SaveSoftware(ClsSoftware soft, out string msg)
        {
            StreamWriter sWriter = new StreamWriter(new FileStream(filePathSoftware, FileMode.Append, FileAccess.Write));
            sWriter.WriteLine(soft.ToString());
            msg = "The Software was created.";
            sWriter.Close();
        }

        public static List<ClsSoftware> GetListSoftware()
        {
            List<ClsSoftware> listSoftware = new List<ClsSoftware>();
            StreamReader sReader = new StreamReader(filePathSoftware);
            string line = sReader.ReadLine();
            while (line != null)
            {
                ClsSoftware soft = new ClsSoftware();
                string[] field = line.Split('|');
                soft.SoftId = Convert.ToUInt16(field[0]);
                soft.ProductName = field[1];
                soft.SoftType = (EnumSoftType)Enum.Parse(typeof(EnumSoftType), field[2]);
                soft.Price = Convert.ToDecimal(field[3]);
                soft.Quantity = Convert.ToUInt16(field[4]);
                soft.Publisher.BusinessName = field[5];
                listSoftware.Add(soft);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listSoftware;
        }
    }
}
