using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetLibrary
{

    public class GreetingProgram
    {
      
        public delegate void GreetingHandler(string name);

  
        public event GreetingHandler OnGreet;

        public void GetUserInput()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

           
            if (OnGreet != null)
            {
                OnGreet(name);
            }
        }
    }
}
