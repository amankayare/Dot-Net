using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main1(string[] args)
        {
            /*
            Mypoint p; // In this way default constructor is not there therefore no initialisation of the default values of X and Y hence need to initailse explicitly
            p.X = 100;
            p.Y = 200;
            Console.WriteLine(p.X);
            Console.WriteLine(p.Y);
            */
            Mypoint p1 = new Mypoint(); // In this way default constructor is initialising the default values of X and Y
            Console.WriteLine(p1.X);
            Console.WriteLine(p1.Y);

            int i;
            // Console.WriteLine(i); this is not allowed because int is struct and we have not initialised it.
            //Console.WriteLine(i);

        }
        static void Main(string[] args)
        {
            //   Display(0); // parameters are int therefore we cant predict what are possible values there fore we should go for enum
            Display(MyTime.night);
            Console.ReadLine();
        }
        static void Display(MyTime a)
        {

            if ( a == MyTime.morning)
                Console.WriteLine("good morning!!");
            if (a == MyTime.noon)
                Console.WriteLine("good noon!!");
            if (a == MyTime.afternoon)
                Console.WriteLine("good afternoon!!");
            if (a == MyTime.evening)
                Console.WriteLine("good evening!!");
            if (a == MyTime.night)
                Console.WriteLine("good night!!");
        }
    }
    public enum  MyTime // : long -> for taking long MyTime
    { // all enums internnaly they are int therefore indirectly enum is an struct
        morning =10,
        noon = 20,
        afternoon,
        evening,
        night
    }
public struct Mypoint{

       /* public Mypoint()
        {   
            No para contr is not allowed in struct
        }*/
        public Mypoint(int X, int Y)
        {
            this.X = Y;
            this.Y = Y;
        }
        public int X;
        public int Y;


    }
}
