using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessRules
{
    public interface ITransaction
    {
        void Rent();
        void Buy();
        void Sell();
    }
}
