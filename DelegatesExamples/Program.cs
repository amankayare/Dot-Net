using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    public delegate void Del1();// step 1
    class Program
    {
        static void Main1(string[] args)
        {
            Del1 ob = new Del1(Display);// step 2 -> ob is pointing to function display()
            ob();// step 3 invoke Display using delegate

            Console.ReadLine();
        }
        static void Main2(string[] args)
        {
            // using single delegates calling two methods
            Del1 ob;
            ob= new Del1(Display);
            ob();

            ob = new Del1(Show);
            ob();
            Console.ReadLine();


        }
        static void Main3(string[] args)
        {
            // multicast inheritance example
            Del1 ob;
            ob = new Del1(Display);
            ob();// display()

            Console.WriteLine();
            Console.WriteLine();

            ob += new Del1(Show);// now ob is pointing to both display and show
            ob();// display() show()

            Console.WriteLine();
            Console.WriteLine();

            ob -= new Del1(Show);// now ob is not pointing to show
            ob();// display()
            Console.ReadLine();

        }

        static void Main4(string[] args)
        {
            // multicast inheritance example
            Del1 ob;
            ob = new Del1(Display);
            ob();// display()

            Console.WriteLine();
            Console.WriteLine();

            ob += new Del1(Show);// now ob is pointing to both display and show
            ob();// display() show()

            Console.WriteLine();
            Console.WriteLine();
         
            ob += new Del1(Display);
            ob();// display()


            Console.WriteLine();
            Console.WriteLine();


            ob -= new Del1(Display);//removes the latest added Display
            ob();// Display() show() 
            Console.ReadLine();

        }
        static void Main5(string[] args)
        {
            
            Del1 ob;
            ob = Display; // same as new Del(Display)
            ob();// display()

            Console.ReadLine();

        }
        static void Main6(string[] args)
        {

            // using static methods of Delegate Class to operate on delegate
            Del1 ob = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display)); // ob = new Del1(Display), ob += new Del1(Show), ob += new Del1(Display)
            ob();

            Console.WriteLine();
            Console.WriteLine();

            ob = (Del1)Delegate.Remove(ob,new Del1(Display)); //  remove latest added display
            ob();

            Console.WriteLine();
            Console.WriteLine();

            ob = (Del1)Delegate.RemoveAll(ob, new Del1(Display)); //  remove all added display
            ob();
            Console.ReadLine();

        }
      
        static void Display()
        {
            Console.WriteLine("Display() Invoked..");
        }
        static void Show()
        {
            Console.WriteLine("Show() Invoked..");
        }
       
    }
}
/*
 
- we are asking someone else to call a function for us.
- similar to function pointers in c++ i.e. delegates are function pointers of c++
- delegate is actually is a class and using this class we are going to call function
- To call a function using delegate:
step 1: Create a Delegate class at namespace level or inside an another class having a same signature as a func to call
 SYNTAX:     public delegate void Del1();
step 2:  Create a Delegate object passing the function name as parameter
step 3: Call the func via the delegate object


-when to use delegates
*Delegates are similar to C++ function pointers, but are type safe.
*Delegates allow methods to be passed as parameters.
*Delegates can be used to define callback methods.
*Delegates can be chained together; for example, multiple methods can be called on a single event.
*Methods don't need to match the delegate signature exactly. For more information, see Covariance and Contra variance.
*C# version 2.0 introduces the concept of Anonymous Methods, which permit code blocks to be passed as parameters in place of a separately defined method.

      inherits            inherits                          inherits
Object<---------- Delegate<--------------MulticastDeleget<--------------Del1(Our delegate class)
Multicast class is able to point more then one function at a time

Del2 obj;
obj = Display;

    OR

Del2 obj;
obj = new Del2(Display);



** if single Delegate pointing multiple function  does not return all function value but the last value 

 */

namespace ParaDelegates
{
    public delegate void Del1();

    public delegate int DelAdd(int a , int b);// step 1
    class Program
    {
        static void Main7(string[] args)
        {
            DelAdd objDelAdd = Add;// step 2 
            Console.WriteLine(objDelAdd(10,20));// step 3
            Console.ReadLine();
        }


        static void Display()
        {
            Console.WriteLine("Display() Invoked..");
        }
        static void Show()
        {
            Console.WriteLine("Show() Invoked..");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

/*
 
 TODO : try multicast delegates with parameters and return value
 
 
 */

namespace staticFunctionOfOtherClassUsingDelegates
{
    public delegate void Del1();

    public delegate int DelAdd(int a, int b);// step 1
    class Program
    {
        static void Main8(string[] args)
        {
            DelAdd objDelAdd = Class2.Add;// step 2 
            Console.WriteLine(objDelAdd(10, 20));// step 3
            Console.ReadLine();
        }


        static void Display()
        {
            Console.WriteLine("Display() Invoked..");
        }
        static void Show()
        {
            Console.WriteLine("Show() Invoked..");
        }
        
    }
    class Class2
    {
       public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

namespace NonStaticFunctionOfOtherClassUsingDelegates
{
    public delegate void Del1();

    public delegate int DelAdd(int a, int b);// step 1
    class Program
    {
        static void Main9(string[] args)
        {
            Class2 c2 = new Class2();
            DelAdd objDelAdd = c2.Add;// step 2 
            Console.WriteLine(objDelAdd(10, 20));// step 3
            Console.ReadLine();
        }


        static void Display()
        {
            Console.WriteLine("Display() Invoked..");
        }
        static void Show()
        {
            Console.WriteLine("Show() Invoked..");
        }

    }
    class Class2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
namespace RecieveParameterAsDelegateType
{
    public delegate int DelAdd(int a, int b);

    class Program
    {
        static void Main()
        {
            Console.WriteLine(PassMethodToCallAsAParameter(Add,100,22));
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine(PassMethodToCallAsAParameter(Sub, 100, 20));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(PassMethodToCallAsAParameter(new DelAdd(Mul), 100, 20)); // internally it is converted like this so both ways are correct
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(PassMethodToCallAsAParameter(Div, 100, 20));
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();

        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }
        static int PassMethodToCallAsAParameter(DelAdd objDelAdd,int a,int b)// objDelAdd = Add , a =20 , b= 10
        {
            return objDelAdd(a,b);
        }
    }
}