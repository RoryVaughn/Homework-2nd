using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsm
{
    class Program
    {

        public void leggo()
        {
           
        }
        public class data
        {
            public List<int> Numbers;
           


        }
        private List<Enum> States;

        bool AddState(Enum state)
        {
            if (state.GetType() == typeof(Enum))
            {
                States.Add(state);
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {




        }
    }
}
