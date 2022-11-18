using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsAuthor : ClsPerson
    {
        private ushort authorId;
        public ushort AuthorId{
            get { return authorId; }
            set { authorId = value; }
        }

        private EnumAuthorGenre authorGenre;
        public EnumAuthorGenre AuthorGenre{
            get { return authorGenre; }
            set { authorGenre = value; }
        }

        private string referenceAndWebsites;
        public string ReferenceAndWebsites{
            get { return referenceAndWebsites; }
            set { referenceAndWebsites = value; }
        }

        public ClsAuthor() : base() {

        }
        
        public ClsAuthor(string firstName, string lastName, ushort age, EnumSexGenre sexGenre, ushort streetNumber, string streetName, ushort appNumber, string postalCode,
                         string city, string state, string phone, string email, EnumPersonType typePerson, ushort authorId, EnumAuthorGenre authorGenre, string referenceAndWebsites) 
            : base(firstName, lastName, age, sexGenre, streetNumber, streetName, appNumber, postalCode, city, state, phone, email, typePerson) 
        {
            this.authorId = authorId;
            this.authorGenre = authorGenre;
            this.referenceAndWebsites = referenceAndWebsites;
        }

        public override string ToString()
        {
            return base.ToString() + "|" + authorId + "|" + authorGenre + "|" + referenceAndWebsites;
        }
    }
}
