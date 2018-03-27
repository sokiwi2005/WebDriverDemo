using System;

namespace loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //I want to print my name five times

              string name = "Sonal";
              for (int i = 0; i < 5; i++) 
              {
                  Console.WriteLine(name);
              }
/*
              // print 0 to 10


            //Assignment -- when to stop -- what to do after the first loop

              for (int i = 0; i < 11; i++)
              {
                  Console.WriteLine(i);
              } */
            /* int sum = 0;

             for (int i = 0; i < 11; i++ )
             {
                 sum = sum + i;
                 Console.WriteLine(i);
             }
             Console.WriteLine(sum);
             */

          /*  int sum = 0;
            int[] marks = { 40, 50, 60, 70, 80, 90 };


            for (int i = 0; i < marks.Length ; i++)
            {
                sum = sum + marks[i];
            }
            Console.WriteLine(sum);


            /*
            for (int i = 100; i > -1; i-- )
            {
                Console.WriteLine(i);
            }
            */
/*            Human boy = new Human("Tom");
            var boyName = boy.getName();
            Console.WriteLine(boyName); */
        }
    }
}
