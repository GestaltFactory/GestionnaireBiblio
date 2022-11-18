using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryBusinessRules;

namespace ClassLibraryIOdata
{
    public class DistributorIO
    {
        const string dir = @"";
        const string filePathDis = dir + "Distributor.txt";

        public static void SaveDis(ClsDistributor dis, out string msg)
        {
            StreamWriter sWriter = new StreamWriter(new FileStream(filePathDis, FileMode.Append, FileAccess.Write));
            sWriter.WriteLine(dis.Display());
            msg = "The Publisher was created.";
            sWriter.Close();
        }

        public static List<ClsDistributor> GetListDistributor()
        {
            List<ClsDistributor> listDis = new List<ClsDistributor>();
            StreamReader sReader = new StreamReader(filePathDis);
            string line = sReader.ReadLine();
            while (line != null)
            {
                ClsDistributor dis = new ClsDistributor();
                string[] field = line.Split('|');
                dis.BusinessName = field[0];
                dis.Address = new ClsAddress(Convert.ToUInt16(field[1]), field[2], Convert.ToUInt16(field[3]), field[4], field[5], field[6]);
                dis.Phone = field[7];
                dis.Email = field[8];
                dis.DisId = Convert.ToUInt16(field[9]);
                dis.TypeDisItem = (EnumTypeItem)Enum.Parse(typeof(EnumTypeItem), field[10]);
                listDis.Add(dis);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listDis;
        }
    }
}
