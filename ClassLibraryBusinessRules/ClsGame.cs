using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public class ClsGame : ClsSoftware
    {
        private GameGenre game;
        public GameGenre Game{
            get { return game; }
            set { game = value; }
        }

        public ClsGame() : base() {
            
        }

        //public ClsGame(string id, string title, decimal price, ushort quantity, ClsAuthor autors, ClsPublisher publisher, string pubDate, EnumStatus status, EnumTypeItem typeItems, EnumSoftType softType, GameGenre game)
        //    : base(id, title, price, quantity, autors, publisher, pubDate, status, typeItems, softType)
        //{
        //    this.game = game;
        //}
    }
}
