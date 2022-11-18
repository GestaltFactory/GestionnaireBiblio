using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsMovie
    {
        private double duration;
        public double Duration{
            get { return duration; }
            set { duration = value; }
        }

        private EnumGenre genre;
        public EnumGenre Genre{
            get { return genre; }
            set { genre = value; }
        }
        
        public ClsMovie() : base() {
            
        }

        public ClsMovie(string id, string title, decimal price, ushort quantity, ClsAuthor autors, ClsPublisher publisher, string pubDate, EnumStatus status, EnumTypeItem typeItems, double duration, EnumGenre genre)

        {
            this.duration = duration;
            this.genre = genre;
        }
    }
}
