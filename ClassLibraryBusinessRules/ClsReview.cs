using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsReview
    {
        private ClsCd nbOfCd;
        public ClsCd NbOfCd{
            get { return nbOfCd; }
            set { nbOfCd = value; }
        }
        
        public ClsReview() : base() {
            nbOfCd.Cd = 0;
        }

        public ClsReview(string id, string title, decimal price, ushort quantity, ClsAuthor autors, ClsPublisher publisher, string pubDate, EnumStatus status, EnumTypeItem typeItems, ClsCd nbOfCd)

        {
            this.nbOfCd = nbOfCd;
        }
    }
}
