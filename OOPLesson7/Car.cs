using OOPLesson7.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson7
{
    internal class Car : IType, IPrint
    {
        public string GetPrint()
        {
            return "sdfsd";
        }

        public int GetType()
        {
            return 1;
        }
    }
}
