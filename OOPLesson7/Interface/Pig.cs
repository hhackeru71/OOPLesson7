using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson7.Interface
{
    internal class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("hello pig");
        }
    }

   
}
