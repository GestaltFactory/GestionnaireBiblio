using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsLearning : ClsSoftware
    {
        private EnumCategory category;
        public EnumCategory Category{
            get { return category; }
            set { category = value; }
        }

        public ClsLearning() : base() {
            
        }

        //public ClsLearning(string id, string title, decimal price, ushort quantity, ClsAuthor autors, ClsPublisher publisher, string pubDate, EnumStatus status, EnumTypeItem typeItems, EnumSoftType softType, EnumCategory category)
        //    : base(id, title, price, quantity, autors, publisher, pubDate, status, typeItems, softType)
        //{
        //    this.category = category;
        //}
    }
}
