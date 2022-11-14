using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson7
{
    abstract class Person// base 
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public  abstract string GetString();//הצהרה 
        public abstract string GetString2();//הצהרה

    }
}
