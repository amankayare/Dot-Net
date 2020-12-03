using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValues
{
   
    class Program
    {
        static void Main1(string[] args)
        {
            Test1 t1 = new Test1();
            Test1 t2 = new Test1();
            t1.i = 100;// t1 -> [i=100]
            t2.i = 200;// t2 -> [i=200]

            t1 = t2; // t1 points to t2 
            //  t2 -> [i=100] <- t1

            t2.i = 300;//  t1 -> [i=300] <- t2

            Console.WriteLine(t1.i);//300
            Console.WriteLine(t2.i);//300

            Console.ReadLine();
        }
        public class Test1
        {
            public int i;
        }
        static void Main2(string[] args)
        {
            int t1, t2;
            t1 = 100;// t1 -> [100]
            t2 = 200;// t2 -> [200]

            t1 = t2; // t2 copied to t1 
            //  t1 -> [200]  
            // t2 -> [200]

            t2 = 300;//  t2 -> [300] 

            Console.WriteLine(t1);//200
            Console.WriteLine(t2);//300

            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            // string classes is exception in reference type becoz string are immutable in DotNet
            string t1, t2;
            t1 = "100";// t1 -> ["100"]-AB56
            t2 = "200";// t2 -> ["200"]-AD45

            t1 = t2; // here is the difference .it create another block of memory and t1 is now pointing to new memory block and value is copied into t1 
            // t1 -> ["200"]-ADB2 (new block)

            t2 = "300";// here also new memry block is created 
            // t2 -> ["300"]-ACB9 (new block)

            Console.WriteLine(t1);//200
            Console.WriteLine(t2);//300

            Console.ReadLine();
        }
        static void Main4(string[] args)
        {
            int i = 1;
            int j = 2;
            Swap(i, j);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();

            SwapRef(ref i, ref j);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();

            int a ;
            int b ;
            init(out a, out b);
            SwapRef(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
        static void Swap(int i,int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;
        }
        static void SwapRef(ref int i, ref int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;
        }
        // out is similar to ref changes made in function reflect back in calling function
        // Indirectly out returns multiple values from a function
        static void init( out int a, out int b)
        {
            // The initial values is discarded
            // Console.WriteLine(a);
            a = 100;
            b = 200;
        }
        static void Main(string[] args)
        {
            Test1 t = new Test1();
            t.i = 100;

            DoSomething1(t);

            Console.WriteLine(t.i);//200
            Console.ReadLine();

            t.i = 100;
            DoSomething2(t);
            Console.WriteLine(t.i);//100
            Console.ReadLine();

            t.i = 100;
            DoSomething3(ref t);
            Console.WriteLine(t.i);//200
            Console.ReadLine();

        }
        static void DoSomething1(Test1 obj) // obj -> t
        {
            obj.i = 200;
        }
        //reference type - if new object is created, the calling code(Main) does not point to the new object
        static void DoSomething2(Test1 obj) // obj -> t
        {
            obj = new Test1(); // obj-> new obj so obj has changed but now changes made in obj will not reflect in t
            obj.i = 200;
        }
        //reference type passed as ref - if new object is created, the calling code(Main) points to the new object
        static void DoSomething3(ref Test1 obj) // obj -> t
        {
            obj = new Test1(); //we create a new object here and now  obj pointing to -> new memory so obj has changed and due to pass by ref it will reflect in 't' also
            obj.i = 200;
        }


        static void DataTypes()
        {
            byte b1;
            sbyte b2;
            char ch;
            short sh1;
            ushort sh2;
            int i1; //System.Int32 //4
            uint i2;//System.UInt32 //4
            long l1;
            ulong l2;
            float f;
            double d;
            decimal d2;
            bool b;

            string s;
            object o;

        }
    }


}
/*
 
 Reference Types : 
- All classes and thier variants are Ref Type
** All classes , Interfaces , delegates , objects class , array and the string class are reference type
- Memory for the obj is allocated on the heap , the reference is allocated on stack
|        |
| t1=123 |---------
| t2=456 |-----    |
|________|     |   |
stack     _____|   |
__________|__      |
|         | |      |
|______<--| |      |
||_300_|<---|------
| 456       |
|___________|
    Heap
OUTPUT:
t1.i =300
t2.i = 300
Value Types: 
- All struct and their variants are value types
** All struct and enums are value type
- Memmory alloction is on stack
 
|           |
| t1= 100   |
| t2= 200   |
| t1=t2=200 |
| t2 = 300  |
|___________| 
OUTPUT:
t1 = 200
t2 = 300
 */