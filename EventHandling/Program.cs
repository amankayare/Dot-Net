using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventHandling
{
    class Program
    {    // User  code 
        static void Main1(string[] args)
        {
            Class1 ob = new Class1();// user will create object of programmers class i.e. Class1
            ob.InvalidP1 += InvalidP1Event;// user will bind his event handler function to the programmers event delegate

            ob.P1 = 100;// This line may raise an event if P1 is set > 99

            Console.WriteLine();
            Console.WriteLine();

            ob.InvalidP1 += AnotherInvalidP1Event; // now our event have two handler function
            ob.P1 = 100;


            Console.WriteLine();
            Console.WriteLine();
            ob.InvalidP1 -= AnotherInvalidP1Event; // now our event again pointing to single function and we have one handler function
            ob.P1 = 100;

            Console.WriteLine();
            Console.WriteLine();
            ob.InvalidP1 -= InvalidP1Event; //  now we have removed all handler functions so 
            ob.P1 = 100; //  now this should give runtime error becoz no event handler functions are there so to handle this we should check weather
                        // delegate  object is null or not before calling delegate object
                        //


            Console.ReadLine();
        }
        static void InvalidP1Event()
        {
            Console.WriteLine("Invalid Event Code here");
        }
        static void AnotherInvalidP1Event()
        {
            Console.WriteLine("AnotherInvalidP1Event Invalid Event Code here");
        }
    }


    // Programmers code class/delegate/methods

    //step 1 : create a delegate class having the same signature as the event handler function
    public delegate void InvalidP1EventHandler();
    class Class1
    {
        // step 2: Declare the  event of delegate  class type (delegate object)
        public event InvalidP1EventHandler InvalidP1; //  its an normal delegate just by adding event keyword we are telling .net that its delagate for event

        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    // raise event here
                    // step 3: call the delegate object
                    if(InvalidP1 != null)
                    InvalidP1();
                }

            }
        }
    }
}


namespace CustomEventHandlingWithParameter
{
    class Program
    {    // User  code 
        static void Main(string[] args)
        {
            Class1 ob = new Class1();// user will create object of programmers class i.e. Class1
            ob.InvalidP1 += InvalidP1Event;// user will bind his event function to the programmers event delegate

            ob.P1 = 10;// This line may raise an event if P1 is set > 99

           


            Console.ReadLine();
        }
        static void InvalidP1Event(int value)
        {
            Console.WriteLine("Invalid input: "+value+"... Value should be < 100");
        }
        
    }


    // Programmers code class/delegate/methods

    //step 1 : create a delegate class having the same signature as the event handler function
    public delegate void InvalidP1EventHandler(int Value);
    class Class1
    {
        // step 2: Declare the  event of delegate  class type (delegate object)
        public event InvalidP1EventHandler InvalidP1; //  its an normal delegate just by adding event keyword we are telling .net that its delagate for event

        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    // raise event here
                    // step 3: call the delegate object
                    if (InvalidP1 != null)
                        InvalidP1(value);
                }

            }
        }
    }
}
