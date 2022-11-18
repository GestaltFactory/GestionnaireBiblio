using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsApps : ClsSoftware
    {
        private EnumSoftGenre softGenre;
        public EnumSoftGenre SoftGenre{
            get { return softGenre; }
            set { softGenre = value; }
        }

        public ClsApps() : base() {
            
        }

        //public ClsApps(string id, string title, decimal price, ushort quantity, ClsAuthor autors, ClsPublisher publisher, string pubDate, EnumStatus status, EnumTypeItem typeItems, EnumSoftType softType, EnumSoftGenre softGenre)
        //    : base(id, title, price, quantity, autors, publisher, pubDate, status, typeItems, softType)
        //{
        //    this.softGenre = softGenre;
        //}
    }
}
