using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class Program
    {
        static void Main1(string[] args) 
        {
            Action o1 = Display;
            o1();
            
            Action<string> o2 = Display;
            o2("Aman");

            Action<string,int> o3 = Display;
            o3("Aman",10);

            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Display()");
        }
        static void Display(string s)
        {
            Console.WriteLine("Display() "+s);
        }
        static void Display(string s , int i)
        {
            Console.WriteLine("Display() " + s +" i: "+i);
        }
    }
}
/*
 There are some inbuilt delegates provided by dot net 
** last generic passed is return type (Right most) and rest are for parameters passed.

- if return type is void -> Action Delegate

    Action<> o1 = Display;
    o1();

 - if return type is non void -> Func Delegate
    Func<> o1 = Display;

 -if your return type is bool and para is single then -> Predicate<>

 */

namespace FuncDelegate
{
    class Program
    {
        static void Main2(string[] args)
        {
            Func<int,int,int> o1 = Add;
            Console.WriteLine(o1(10, 10));

            Func<string,short,int> o2 = DoSomething;
            o2("Aman",2);

            Func<int, bool> o3 = IsEven;
            Console.WriteLine(o3(10)); 


            Predicate<int> o4 = IsEven; // no need to provide return type becoz return type is understood i.e. boolean
            o4(10);

            Console.ReadLine();
        }
        static int Add(int a, int b)
        {
            Console.WriteLine("Add()");
            return a + b;
        }
        static int DoSomething(string a, short b)
        {
            Console.WriteLine("DoSomething(string a,short b)");
            return 1;
        }
        static bool IsEven(int a)
        {
            return a % 2 ==0;
        }
    }
}

namespace AnonymousMethod
{   
    /*Anynymous methods is methods which dont have Name and can be defined using delegates*/
    class Program
    {
        static void Main3(string[] args)
        {
            int i = 100;
            Action o1 = delegate { // no parameters
                Console.WriteLine("Anonymous");
            };
            o1();

            Action<int> o2 = delegate(int a) { // with parameters
                Console.WriteLine("Anonymous with para "+a);
                ++i; // Anonymous method can access variable defined in the calling code
            };
            o2(10);



            // another anonymous method using Func delegate
            Func<int, int, int> o3 = delegate (int a, int b)
            {
                  Console.WriteLine("Anonymous Add()");
                  return a + b;
            };
            o3(10, 20);
            Console.ReadLine();
        }
      
        static int DoSomething(string a, short b)
        {
            /*i++;  variable i is not present in this method but in main method so  cant access variable of another method
             with non anonymous method*/
            Console.WriteLine("DoSomething(string a,short b)");
            return 1;
        }
       
    }
}

namespace Lambdas
{
    /*
     - Lambdas are another way to write Anynymous methods with more shorter way.
     - Lambdas are mainly used for Link Qureies
      
     */
    class Program
    {
        static void Main(string[] args)
        {
            // anonymous method using Lambda
            Func<int, int> o1 = x => x * 2; // here o1 is delegate object , first x is the int parameter and second x is used in the lambda body
            Console.WriteLine(o1(10));
        
            // same anonymous method using  delegate
            Func<int, int> o2 = delegate (int a)
            {
                Console.WriteLine("Anonymous Method()");
                return a*2;
            };
            Console.WriteLine(o2(20));


            // for return type and more parameters
            Func<int, int,int> o3 = (a, b) => a + b;
            Console.WriteLine(o3(10,20));


            // for multi line lambda function
            Func<int, int, int, int> o4 = (a, b, c) =>
            {   // multi line code goes here
                Console.WriteLine("Multiple Lines here");
                return a + b + c;
            };
            Console.WriteLine(o4(10, 20, 30)); 
            Console.ReadLine();
        }

        static int MakeDouble(int b)
        {
            
            Console.WriteLine("DoSomething(int b)");
            return b*2;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

    }
}