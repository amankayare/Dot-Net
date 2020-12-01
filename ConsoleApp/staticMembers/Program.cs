using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMembers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---LINE---");
            Class1 o1 = new Class1();
            Console.WriteLine(Class1.s_P1);
            Console.WriteLine("---LINE---");

            Class1 o2 = new Class1();
            o1.i = 100;
            o2.i = 200;
            Class1.s_i = 123;
            Console.WriteLine(Class1.s_i);
            o1.Display();
            Class1.s_Display();
            // o1.s_Display();// not allowed

            Class1.s_P1 = 10;
            Console.WriteLine(Class1.s_P1);
            Console.ReadLine();
        }
    }
    class Class1
    {
        public int i;
        // static variable - single copy for the classes
        public static int s_i;

        static Class1(){

            Console.WriteLine("static contr");
            s_P1 = 1000;
            s_i = 20;

         }

        public void Display()
        {
            Console.WriteLine("simple disp");
            Console.WriteLine(i);// allowed (current object's 'i' )
            Console.WriteLine(s_i);// allowed
        }
        // static method -> to call method using class name only we use static method
       public static void s_Display()
        {
            Console.WriteLine("static disp");
            //Console.WriteLine(i);// not allowed because each object has its own variable 'i' and we are calling our static Display method using class name 
            // so its ambiguity its not able to identify which 'i' it was. 
            Console.WriteLine(s_i);// allowed
        }

        //property
        private static int s_p1; // convention -> 
        public static int s_P1
        { // convention -> property
            set         // get called when ClassName.P1=10
            {
                // passed value is available as 'value' -> keyword
                if (value < 100)
                    s_p1 = value;
                else
                    Console.WriteLine("invalid P!");

            }
            get    // get called when ClassName.P1
            {
                return s_p1;
            }

        }
    }
    public static class s_Class1

    {
        // can have only static members
        // can not be instantiated
        // can not be used as based class i.e. cant be inherited
        // cant have non static constr
        static  s_Class1()
        {

        }
    }
}
