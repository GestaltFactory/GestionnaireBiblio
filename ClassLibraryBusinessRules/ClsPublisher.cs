using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsPublisher : ClsPerson
    {
        private ushort pubId;
        public ushort PubId
        {
            get { return pubId; }
            set { pubId = value; }
        }

        private EnumAuthorGenre authorGenre;
        public EnumAuthorGenre AuthorGenre
        {
            get { return authorGenre; }
            set { authorGenre = value; }
        }

        private ushort nbOfBooksPublished;
        public ushort NbOfBooksPublished{
            get { return nbOfBooksPublished; }
            set { nbOfBooksPublished = value; }
        }

        public ClsPublisher() : base() {

        }
        
        public ClsPublisher(string businessName, ushort streetNumber, string streetName, ushort appNumber, string postalCode, string city, string state,
                            string phone, string email, EnumPersonType typePerson, ushort pubId, EnumAuthorGenre authorGenre, ushort nbOfBooksPublished)
            : base(businessName, streetNumber, streetName, appNumber, postalCode, city, state, phone, email, typePerson)
        {
            this.pubId = pubId;
            this.nbOfBooksPublished = nbOfBooksPublished;
            this.authorGenre = authorGenre;
        }

        public override string Display(){
            return base.Display() + "|" + pubId + "|" + authorGenre + "|" + nbOfBooksPublished;
        }

    }
}
