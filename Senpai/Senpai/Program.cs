using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senpai
{
    public interface IHighschooler
    {
        string School
        {
            get;
            set;
        }
        int Grade
        {
            get;
            set;
        }
        int Senpainotice
        {
            // if senpai attends the same school && is in a Higher Grade => return true  
            get;
            set;
        }
    }
    public interface IMechpilot
    {
        string Mechname
        {
            get;
            set;
        }
        int Attack
        {
            get;
            set;
        }
        int Defence
        {
            get;
            set;
        }
        
    }
    public interface IMonster
    {
        int Level
        {
            get;
            set;
        }
        int ItsAnAngel
        {
            // if angel Level is higher than 1/3 your Defence => return (MechName + " Lost in Battle./n")
            //	else return (MechName + "  Continues the fight./n")
            // if angel Level is higher than 1/4 your Attack => return (MechName + "'s Attacks did nothing./n")
            // 	else return (MechName + " Defeated the monster./n")

            get;
            set;
        }
    }

    public class Protagonist : IHighschooler, IMechpilot
    {
        public int Attack
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Defence
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Grade
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Mechname
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string School
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Senpainotice
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
    public class SadTwist : IHighschooler, IMonster
    {
        public int Grade
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int ItsAnAngel
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Level
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string School
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Senpainotice
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }






    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
