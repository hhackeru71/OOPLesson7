using OOPLesson7;
using OOPLesson7.Task;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("yarin");//error compiler
            //Person person2 = new Students(30, "yarin");//good
            //Console.WriteLine(person2.GetString());
            Shape circle = new Circle(2.6);
            Console.WriteLine(circle.GetArea());
            Shape line = new Line(3.5);
            Console.WriteLine(line.GetArea());
            //להדפיס את GetArea
            //shape c = new Line();

            //ליצור מחלקה  shape  abstract

            //ליצור פונקציה GetArea .abstract //סוג  double

            //מחלקה circle  שיורשת מshape

            //prop:
            //radius double

            // ליצור פונקציה של GetArea ovrride


            //ליצור מחלקה Line  שיורשת מshape
            //
            // prop
            // x double
            //

            // ליצור פונקציה של GetArea ovrride 
            //

            //main

            //shape b = new circle();
            //להדפיס את GetArea
            //shape c = new Line();
            //להדפיס את GetArea


        }
    }
}
