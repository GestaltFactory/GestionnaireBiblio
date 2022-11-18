using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsCd 
    {
        private ushort cd;
        public ushort Cd{
            get { return cd; }
            set { cd = value; }
        }
        
        public ClsCd() : base() {

        }

        public ClsCd(string id, string title, decimal price, ushort quantity, ClsAuthor autors, ClsPublisher publisher, string pubDate, EnumStatus status, EnumTypeItem typeItems, ushort cd)

        {
            this.cd = cd;
        }
    }
}
