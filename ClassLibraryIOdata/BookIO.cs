using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryBusinessRules;

namespace ClassLibraryIOdata
{
    public class BookIO
    {
        const string dir = @"";
        const string filePathBook = dir + "Book.txt";
        const string filePathBookMod = dir + "TempBook.txt";

        public static void SaveBook(ClsBook book, out string msg)
        {
            StreamWriter sWriter = new StreamWriter(new FileStream(filePathBook, FileMode.Append, FileAccess.Write));
            sWriter.WriteLine(book.ToString());
            msg = "The book was created.";
            sWriter.Close();
        }

        public static List<ClsBook> GetListBook()
        {
            List<ClsBook> listBook = new List<ClsBook>();
            StreamReader sReader = new StreamReader(filePathBook);
            string line = sReader.ReadLine();
            while (line != null)
            {
                ClsBook book = new ClsBook();
                string[] field = line.Split('|');
                book.Isbn = field[0];
                book.ProductName = field[1];
                book.BookGenre = (EnumAuthorGenre)Enum.Parse(typeof(EnumAuthorGenre), field[2]);
                book.Price = Convert.ToDecimal(field[3]);
                book.Quantity = Convert.ToUInt16(field[4]);
                book.Authors.Name.FirstName = field[5];
                book.Publisher.BusinessName = field[6];
                book.CdIncluded = (EnumCDIncluded)Enum.Parse(typeof(EnumCDIncluded), field[7]);
                listBook.Add(book);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listBook;
        }

        public static ClsBook SearchByISBN(string isbn){
            ClsBook book = new ClsBook();
            if (File.Exists(filePathBook))
            {
                StreamReader sReader = new StreamReader(filePathBook);
                string line = sReader.ReadLine();
                while(line != null){
                    string[] field = line.Split('|');
                    if(field[0] == isbn){
                        book.Isbn = field[0];
                        book.ProductName = field[1];
                        book.BookGenre = (EnumAuthorGenre)Enum.Parse(typeof(EnumAuthorGenre), field[2]);
                        book.Price = Convert.ToDecimal(field[3]);
                        book.Quantity = Convert.ToUInt16(field[4]);
                        book.Authors.Name.FirstName = field[5];
                        book.Publisher.BusinessName = field[6];
                        book.CdIncluded = (EnumCDIncluded)Enum.Parse(typeof(EnumCDIncluded), field[7]);
                        sReader.Close();
                        break;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return book;
        }

        public static ClsBook SearchByPublisher(string str){
            ClsBook book = new ClsBook();
            if (File.Exists(filePathBook))
            {
                StreamReader sReader = new StreamReader(filePathBook);
                string line = sReader.ReadLine();
                while (line != null){
                    string[] field = line.Split('|');
                    if(field[6] == str){
                        book.Isbn = field[0];
                        book.ProductName = field[1];
                        book.BookGenre = (EnumAuthorGenre)Enum.Parse(typeof(EnumAuthorGenre), field[2]);
                        book.Price = Convert.ToDecimal(field[3]);
                        book.Quantity = Convert.ToUInt16(field[4]);
                        book.Authors.Name.FirstName = field[5];
                        book.Publisher.BusinessName = field[6];
                        book.CdIncluded = (EnumCDIncluded)Enum.Parse(typeof(EnumCDIncluded), field[7]);
                        sReader.Close();
                        break;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return book;
        }

        public static bool ModBook(ClsBook book){
            bool success = false;
            if (File.Exists(filePathBook)){
                StreamReader sReader = new StreamReader(filePathBook);
                StreamWriter sWriter = new StreamWriter(new FileStream(filePathBookMod, FileMode.Append, FileAccess.Write));

                string line = sReader.ReadLine();
                while (line != null){
                    string[] field = line.Split('|');
                    if (field[0] != book.Isbn){
                        sWriter.WriteLine(field[0] + "|" + field[1] + "|" + field[2] + "|" + field[3] + "|" + field[4] + "|" + field[5] + "|" + field[6] + "|" + field[7]);
                    }
                    line = sReader.ReadLine();
                }
                sWriter.WriteLine(book.ToString());

                sReader.Close();
                File.Delete(filePathBook);
                sWriter.Close();
                File.Move(filePathBookMod, filePathBook);
            }
            return success;
        }

        public static bool DelBook(string str)
        {
            if (File.Exists(filePathBook))
            {
                StreamReader sReader = new StreamReader(filePathBook);
                StreamWriter sWriter = new StreamWriter(new FileStream(filePathBookMod, FileMode.Append, FileAccess.Write));

                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[0] != str.ToString())
                    {
                        sWriter.WriteLine(field[0] + "|" + field[1] + "|" + field[2] + "|" + field[3] + "|" + field[4] + "|" + field[5] + "|" + field[6] + "|" + field[7]);
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
                File.Delete(filePathBook);
                sWriter.Close();
                File.Move(filePathBookMod, filePathBook);
            }
            return true;
        }
    }
}
