using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson7
{
    internal class Students : Person
    {

        public int Age { get; set; }

        public Students(int age , string name)
            :base(name)
        {
            Age = age;
        }

        public override string GetString()
        {
            return "";
        }

        public override string GetString2()
        {
            throw new NotImplementedException();
        }



    }


}
