using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsBook : ClsProduct
    {
        private string isbn;
        public string Isbn{
            get { return isbn; }
            set { isbn = value; }
        }

        private ClsAuthor authors;
        public ClsAuthor Authors{
            get { return authors; }
            set { authors = value; }
        }

        private EnumAuthorGenre bookGenre;
        public EnumAuthorGenre BookGenre{
            get { return bookGenre; }
            set { bookGenre = value; }
        }

        private EnumCDIncluded cdIncluded;
        public EnumCDIncluded CdIncluded{
            get { return cdIncluded; }
            set { cdIncluded = value; }
        }
        
        public ClsBook() : base() {

        }

        public ClsBook(string productName, decimal price, ushort quantity, ClsPublisher publisher, DateTime pubDate, EnumStatus status, 
                       EnumTypeItem typeItems, string isbn, ClsAuthor authors, EnumAuthorGenre bookGenre, EnumCDIncluded cdIncluded)
            : base(productName, price, quantity, publisher, pubDate, status, typeItems)
        {
            this.isbn = isbn;
            this.authors = authors;
            this.bookGenre = bookGenre;
            this.cdIncluded = cdIncluded;
        }

        public override string ToString()
        {
            return base.ToString() + "|" + isbn + "|" + authors.Name.FirstName + "|" + bookGenre + "|" + cdIncluded;
        }
    }
}
