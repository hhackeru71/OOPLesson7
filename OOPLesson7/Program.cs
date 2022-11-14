using OOPLesson7;
using OOPLesson7.Interface;
using OOPLesson7.Task;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.GetPrint());
            Console.WriteLine(car.GetType());

            //Test test = new Test();
            //Console.WriteLine(test.GetArea());
            //Console.WriteLine(test.Get());
            //ליצור interface  print
            ////פונקציה שמחזירה print כstring // הצהרה

            //ליצור  interface type
            // פונקציה מחזירה את int GetType

            //מחלקה car יורשת מתוך interface print וגם יורשת מ type
            //להחזיר את המספר  1 בפונקציה GetType
            //להחזיר בפונקציה איזה מחרוזת 
            //main

            //להדפיס את פונקציה print


            //Pig pig = new Pig();
            //pig.animalSound();

            ////Person person1 = new Person("yarin");//error compiler
            ////Person person2 = new Students(30, "yarin");//good
            ////Console.WriteLine(person2.GetString());
            //Shape circle = new Circle(2.6);
            //Console.WriteLine(circle.GetArea());
            //Shape line = new Line(3.5);
            //Console.WriteLine(line.GetArea());
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

    interface ITest2
    {
        public string Get();
    }
    interface ITest
    {
        public int GetArea();
    }

    class Test : ITest, ITest2
    {
        public string Get()
        {
            return "sdf";
        }

        public int GetArea()
        {
            return 1;
        }
    }
}
