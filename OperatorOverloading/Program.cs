using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 - Operator overloading is the way of giving differnt meaning to the existing operators
 - redefine existing operators behaviour to work with our class
 - C++
    Class1 o = new Class1();
    o = o + 5;
    o + 5 ==> o.operator+(5)
    
    class class1{

        Class1 operator+(int i){--}
            
    }
 - C# or DotNet
    Class1 o = new Class1();
    o + 5 ==> Class1.operator+(o,5) -> class object and int varible passed as parameters and calling is done using Class Name
 */
namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1 { i = 10 };
            o = o + 5;
            Console.WriteLine(o.i);

            Class1 o2 = new Class1 { i = 10 };
            o = o + o2;

            Console.WriteLine(o.i);

            o = ++o;
            Console.WriteLine(o.i);

            Console.ReadLine();
        }
    }
    public class Class1
    {
        public int i;

        public static Class1 operator+(Class1 o , int a)
        {
            Class1 obj = new Class1();

            obj.i = obj.i + a;
            return obj;
        }
        public static Class1 operator +(Class1 o, Class1 a)
        {
            Class1 obj = new Class1();

            obj.i = obj.i + a.i;
            return obj;
        }
        public static Class1 operator ++(Class1 a)
        {
            Class1 obj = new Class1();

            obj.i = ++obj.i ;
            return obj;
        }
    }

    /*
     we cant overload subscrit operator but can use Indexer instead


    -----------TODO------
     
     
    outputs are wrong check it all once
     */
}

