using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    class Team
    {
        interface I_Abilites
        {
            void M1();
            int M1cd();
            
            
        }
        class Fighter : I_Abilites
        {
            public string name;
            public int health = 500;
            public int mana = 100;
            public int exp = 0;
            public int lvl = 1;

            public void M1()
            {
                throw new NotImplementedException();
            }

           
            public int M1cd()
            {
                throw new NotImplementedException();
            }

        }

        
     }

}
