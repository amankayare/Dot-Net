using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            IntOperations.Swap(ref a,ref b);

            short c = 30;
            short d = 40;
            ShortOperations.Swap(ref c, ref d);

            GenericOperations<int>.Swap(ref a, ref b);
            GenericOperations<short>.Swap(ref c, ref d);


        }
    }

    class IntOperations
    {
        public static void Swap(ref int i , ref int j)
        {
            int temp;
            temp = i;
            i = j;
            j = temp;
        }
    }
    class ShortOperations
    {
        public static void Swap(ref short i, ref short j)
        {
            short temp;
            temp = i;
            i = j;
            j = temp;
        }
    }
    class GenericOperations<T>
        where T : struct            // this are constraints means structs in the only allowed valuetype
    {
        public static void Swap(ref T i, ref T j)
        {
            T temp;
            temp = i;
            i = j;
            j = temp;
        }
    }

}
namespace GenericStack
{

    class Program
    {
        static void Main(string [] args)
        {
            /*  Write implementation  */
            IntegerStack i = new IntegerStack(3);
             //i.Push("Aman"); // string not allowed 
            i.Push(10);
            i.Pop();
            
            StringStack s = new StringStack(3);
            // s.Push(10); int not allowed
            s.Push("Aman");
            s.Pop();

            GenericStack<int> g1 = new GenericStack<int>(3);
            g1.Push(10);
            g1.Pop();

            GenericStack<string> g2 = new GenericStack<string>(3);
            g2.Push("Aman");
            g2.Pop();


        }
    }

    public class IntegerStack
    {
        int[] arr;
        public IntegerStack(int Size)
        {
            arr = new int[Size];
        }
        int Pos = -1;
        public void Push(int i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack Overflow");
            arr[++Pos] = i;
        }
        public int Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack underflow");
            return arr[Pos--];
        }
    }

    class StringStack
    {
        string[] arr;
        int Pos = -1;
        public StringStack(int Size)
        {
            arr = new string[Size];
        }

        public void Push(string i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack Overflow");
            arr[++Pos] = i;
        }

        public string Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack underflow");
            return arr[Pos--];
        }
    }

    class GenericStack<T>
    {
        T[] arr;
        int Pos = -1;

        public GenericStack(int Size)
        {
            arr = new T[Size];
        }

        public  void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack Overflow");
           arr[++Pos]=i;
        }

        public T Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack underflow");
            return arr[Pos--];

        }
    }


}

/*
 
 Generic CONSTRAINTS TYPE

where T : class - T must be a referenve
where T : struct - T must be a value type
where T : ClassName - T must be either ClassName or a derived class
where T : InterfaceName - T must be a class that is implements InterfaceName
where T : new() - T must have a no parameter contr

** We can combine constraints
 
where T : ClassName , InterfaceName
where T : ClassName , InterfaceName
where T : ClassName , struct --------> meaning less contraints , not allowed
where T : struct , ClassName --------> meaning less contraints , not allowed

** if we are using new () then it must appear at the end only
where T : ClassName , InterfaceName , new()
where T : ClassName , new() ,InterfaceName ---------------> not allowed
where T :  new() , ClassName) ,InterfaceName -------------> not allowed

 
 
 */