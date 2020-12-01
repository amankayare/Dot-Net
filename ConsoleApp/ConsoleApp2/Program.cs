using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // for property
        static void Main1(string[] args)
        {
            Class1 o = new Class1();
            //    o.i = 100;
            //    o.i = 200;
            o.SetI(100);
            Console.WriteLine(o.GetI());


            o.P1 = 10; // set will call here
            Console.WriteLine(o.P1);// get will call


            Console.WriteLine(o.P2);// get will call of string

            Console.ReadLine();


        }
        //for constructors nd destructor
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            Console.WriteLine(o.P1);

            o = null;
            GC.Collect();
            Console.ReadLine();


        }

    }
    class Class1
    {
        #region Constructor
        public Class1()
        {
            Console.WriteLine("no params constr called");
            P1 = 5;

        }
     /*   public Class1(int a)
        {
            Console.WriteLine("1 int params constr called");
            //    p1 = a; --> dont do this because property is recommended . 
            P1 = a;

        }
     */
        public Class1(int P1)
        {
            Console.WriteLine("1 int params constr called");
            this.P1 = P1;

        }
        #endregion

        #region Properties
        // public int i = 0;
        private int i = 0;

        public void SetI(int x)
        {
            if (x < 100)
                i = x;
            else
                // throw an exception
                Console.WriteLine("Invalid value");
        }
        public int GetI()
        {
            return i;
        }
        //property
        private int p1; // convention -> 
        public int P1
        { // convention -> property
            set         // get called when o.P1=10
            {
                // passed value is available as 'value' -> keyword
                if (value < 100)
                    p1 = value;
                else
                    Console.WriteLine("invalid P!");

            }
            get    // get called when o.P1
            {
                return p1;
            }

        }



        // For string values
        private string p2;
        public string P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        // READ only 
        private string p3 = "Aman";
        public string P3{
            get{
            return p3;            
            }
         }

        // Properties which dont have validation called Auto or Automatic properties and we have a syntax to write it.
        public int p4 { get; set; }
        // compiler first generate private variable for us no need to create it explicitly and then it will also create setter and getter for us.


        // ___________ allows us to see IL code which is generated-> steps given in video at 10:25AM

        # endregion

        ~Class1()
        {
            Console.WriteLine("Destructor called..");
        }
    }
}