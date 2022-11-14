using OOPLesson7;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("yarin");//error compiler
            Person person2 = new Students(30, "yarin");//good
            Console.WriteLine(person2.GetString());
  



        }
    }
}
