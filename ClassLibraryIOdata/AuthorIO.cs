using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryBusinessRules;

namespace ClassLibraryIOdata
{
    public class AuthorIO
    {
        const string dir = @"";
        const string filePathAuthor = dir + "Author.txt";

        public static void SaveAuthor(ClsAuthor aut, out string msg){
            StreamWriter sWriter = new StreamWriter(new FileStream(filePathAuthor, FileMode.Append, FileAccess.Write));
            sWriter.WriteLine(aut.ToString());
            msg = "The Author was created.";
            sWriter.Close();
        }

        public static List<ClsAuthor> GetListAuthor(){
            List<ClsAuthor> listAuthor = new List<ClsAuthor>();
            StreamReader sReader = new StreamReader(filePathAuthor);
            string line = sReader.ReadLine();
            while (line != null)
            {
                ClsAuthor aut = new ClsAuthor();
                string[] field = line.Split('|');
                aut.Name = new ClsFullName(field[0], field[1]);
                aut.Age = Convert.ToUInt16(field[2]);
                aut.SexGenre = (EnumSexGenre)Enum.Parse(typeof(EnumSexGenre), field[3]);
                aut.Address = new ClsAddress(Convert.ToUInt16(field[4]), field[5], Convert.ToUInt16(field[6]), field[7], field[8], field[9]);
                aut.Phone = field[10];
                aut.Email = field[11];
                aut.AuthorId = Convert.ToUInt16(field[12]);
                aut.AuthorGenre = (EnumAuthorGenre)Enum.Parse(typeof(EnumAuthorGenre), field[13]);
                listAuthor.Add(aut);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listAuthor;
        }
    }
}
