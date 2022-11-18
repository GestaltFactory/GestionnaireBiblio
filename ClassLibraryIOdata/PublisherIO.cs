using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryBusinessRules;

namespace ClassLibraryIOdata
{
    public class PublisherIO
    {
        const string dir = @"";
        const string filePathPub = dir + "Publisher.txt";

        public static void SavePub(ClsPublisher pub, out string msg)
        {
            StreamWriter sWriter = new StreamWriter(new FileStream(filePathPub, FileMode.Append, FileAccess.Write));
            sWriter.WriteLine(pub.Display());
            msg = "The Publisher was created.";
            sWriter.Close();
        }

        public static List<ClsPublisher> GetListPublisher()
        {
            List<ClsPublisher> listPub = new List<ClsPublisher>();
            StreamReader sReader = new StreamReader(filePathPub);
            string line = sReader.ReadLine();
            while (line != null)
            {
                ClsPublisher pub = new ClsPublisher();
                string[] field = line.Split('|');
                pub.BusinessName = field[0];
                pub.Address = new ClsAddress(Convert.ToUInt16(field[1]), field[2], Convert.ToUInt16(field[3]), field[4], field[5], field[6]);
                pub.Phone = field[7];
                pub.Email = field[8];
                pub.PubId = Convert.ToUInt16(field[9]);
                pub.AuthorGenre = (EnumAuthorGenre)Enum.Parse(typeof(EnumAuthorGenre), field[10]);
                pub.NbOfBooksPublished = Convert.ToUInt16(field[11]);
                listPub.Add(pub);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listPub;
        }
    }
}
