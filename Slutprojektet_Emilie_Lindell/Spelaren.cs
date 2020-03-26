using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojektet_Emilie_Lindell
{
    class Spelaren
    {
        private int hp;
        public Spelaren()
        {
            Random gen = new Random();
            hp = gen.Next(25, 50);
        }
       
    }
}
