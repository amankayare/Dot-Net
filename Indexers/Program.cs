using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Indexer
{
    /*
     - Indexers are nothing but if we are having array or collection as an field then can use indexer here array or collection can be of any type
     
    - scenerio:
     using indexer           actuall we want to do this
     obj[0] = 10;  --------> obj.arr[0] = 10
     
     */
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1(5);
            o[0] = 100;
            o[1] = 200;
            o[2] = 300;
            o[3] = 400;
            o[4] = 500;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("o["+i+"]: "+o[i]);
            }


            Console.ReadLine();
        }
    }
    public class Class1
    {
         int []arr;
        public Class1(int size)
        {
            arr = new int[size];
        }
        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }
            get
            {
                return arr[index];
            }
        }

    }
}


namespace CorelationUsingIndexers
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1(20,100);
            o[100] = 100;
            o[101] = 200;
            o[102] = 300;
            o[103] = 400;
            o[104] = 500;

            for (int i = 100; i < 105; i++)
            {
                Console.WriteLine("o[" + i + "]: " + o[i]);
            }


            Console.ReadLine();
        }
    }
    public class Class1
    {
        int[] arr;
        int startPos;
        public Class1(int size,int startPos)
        {
            arr = new int[size];
            this.startPos = startPos;
        }
        public int this[int index]
        {
            set
            {
                arr[index-startPos] = value;
            }
            get
            {
                return arr[index-startPos];
            }
        }

    }
}
