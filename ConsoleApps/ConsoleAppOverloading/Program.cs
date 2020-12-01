using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOverloading
{
    class Program

    {
        static void Main(string[] args)

        {
          System.Console.WriteLine(overloading1.MyClass.Add(10,20));
          System.Console.WriteLine(overloading1.MyClass.Add(10, 20,30));

          System.Console.WriteLine(overloading2.MyClass.Add(10, 20));
          System.Console.WriteLine(overloading2.MyClass.Add(10, 20,30));
          System.Console.WriteLine(overloading2.MyClass.Add(10, 20,30,40));
            System.Console.WriteLine(overloading2.MyClass.NamedAdd(num1:10));
            System.Console.WriteLine(overloading2.MyClass.NamedAdd(num1: 10,num4:20));


            System.Console.ReadLine();

        }
    }
}


namespace overloading1
{
  public  class MyClass
    {
       public static int Add(int num1 , int num2)
        {
            return num1 + num2;
        }
        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 +num3;
        }
    }
}

namespace overloading2
{
   public class MyClass
    {
       
      public static int  Add(int num1=0, int num2=0 , int num3=0,int num4=0)
        {
            return num1 + num2+num3+num4;
        }
        /*
           static int Add(int num1 , int num2 = 0, int num3 = 0, int num4 = 0)
            {
                return num1 + num2 + num3 + num4;
            }
        */
        /* static int Add(int num1=0, int num2 = 0, int num3 = 0, int num4 )
         {
             return num1 + num2 + num3 + num4;
         }
        */

        public static int NamedAdd(int num1 = 0, int num2 = 0, int num3 = 0, int num4 = 0)
        {
            System.Console.WriteLine("num1:"+num1+" num2:"+num2 +" num3:"+num3 +" num4:"+num4);

            return num1 + num2 + num3 + num4;


        }

    }
}