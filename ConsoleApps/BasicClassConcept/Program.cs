using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnotherNameSpace;
namespace BasicClassConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hey DOTNET");


           Test re = new AnotherNameSpace.Test();

            re.Table(2);


           Test2 re2 = new AnotherNameSpace.Test2();

            re2.Table(1);

            re.Table(1,20);



        }
    }
}

namespace AnotherNameSpace
{
  public class Test
    {
       public  void Table(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    System.Console.WriteLine(i + "x" + j + "= " + i * j);

                }
                System.Console.WriteLine("\n");

            }
            System.Console.ReadLine();
        }
        public void Table(int num, int upto)
        {
            System.Console.WriteLine("Two parameter Table" );

            System.Console.ReadLine();
        }
        public void Table(int a, int b, int c, int d)

        {
            System.Console.WriteLine("int a, int b, int c, int d");

            System.Console.ReadLine();
        }

    }
    
}

namespace AnotherNameSpace
{
    public class Test2
    {
        public void Table(int num)
        {
            Console.WriteLine("2nd Antother Name Table");


            System.Console.ReadLine();
        }
       

    }

}

