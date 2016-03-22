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
            void Auto();
            void Spec();
            int cd(int x);
            
            
        }
        class Fighter : I_Abilites
        {
            public string name; //The specific name stored for this specific object.
            public int Max_health;//Maximum amount of mana that this unit can have.
            public int health; //current Health
            public int Max_mana; //Maximum amount of mana that this unit can have.
            public int mana; //current mana
            public int exp; //current experience
            public int lvl; //current overall level
            public int Str; //amount of possible damage
            public int att; //possiblity of hitting the target
            public int def; //damage mitigation

            public void Auto()
            {
                //figure out how to decrease another SPECIFIC units health by strength.
            }

            public void Spec()
            {
                //figure out how to decrease another specific unit's health by a modifier of the strength stat.
                
            }

           
            public int cd(int x)
            {
                //use this as an integer for the cooldown or wait period until the user can use the spcial attack again.
                x = 4;
               
                return x;
            }

        }

        
     }

}
