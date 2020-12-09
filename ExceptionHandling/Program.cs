using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    // simple exception Handling
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 obj = new Class1();
            try {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
            catch
            {
                Console.WriteLine("Exception Occurred");
            }
            Console.ReadLine();
        }
    }
    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
    }
}


namespace CatchingDiffExceptions
{

    class Program
    {
        static void Main2(string[] args)
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException Occurred");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("StackOverflowException Occurred");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException Occurred");
            }
            Console.ReadLine();
        }
    }
    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
    }

}


namespace CatchingWithBaseClass
{

    class Program
    {
        static void Main3(string[] args)
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
            catch (ArithmeticException ex) {// Base class of Divide by is arithmatic
                Console.WriteLine("DivideByZeroException Occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException Occurred");
            }
           
            catch (SystemException ex) //  Base class of FormatException by is System
            {
                Console.WriteLine("FormatException Occurred");
            }
            /* catch (StackOverflowException ex) //      Base class exception has to caught after derived class exception

             {
                 Console.WriteLine("StackOverflowException Occurred");
             }*/
            catch (Exception ex) //  Handle all type of exceptions
            {
                Console.WriteLine("Exception Occurred");
            }
            Console.ReadLine();
        }
    }
    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
    }
    
}


namespace ExceptionWithFinally
{

    class Program
    {
        static void Main4(string[] args)
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
            catch (ArithmeticException ex)
            {// Base class of Divide by is arithmatic
                Console.WriteLine("DivideByZeroException Occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException Occurred");
            }

            catch (SystemException ex) //  Base class of FormatException by is System
            {
                Console.WriteLine("FormatException Occurred");
            }
            /* catch (StackOverflowException ex) //      Base class exception has to caught after derived class exception

             {
                 Console.WriteLine("StackOverflowException Occurred");
             }*/
            catch (Exception ex) //  Handle all type of exceptions
            {
                Console.WriteLine("Exception Occurred");
            }
            finally
            {   // write all clean up code in finally block like close connection or close stream and all
                Console.WriteLine("Finally Code");
            }
            Console.ReadLine();
        }
    }
    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
    }
  
}


namespace NestedTryCatch
{

    class Program
    {
        static void Main5(string[] args)
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("DivideByZeroException Occurred");

              try  {
                    obj = null;
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                    Console.WriteLine("No Exception");
                }
                catch (ArithmeticException e)
                {
                Console.WriteLine(" Nested DivideByZeroException Occurred");
                }
                finally
                {   
                    Console.WriteLine("1nd catch Nested Finally Code");
                }
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException Occurred");


                try
                {
                    obj = null;
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                    Console.WriteLine("No Exception");
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(" Nested NullReferenceException Occurred");
                }
                finally
                {
                    Console.WriteLine("2nd catch Nested Finally Code");
                }
            }
            finally
            {   
                Console.WriteLine("Outer Finally Code");
            }
            Console.ReadLine();
        }
    }
    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
    }

}


namespace UserDefinedExceptions 
{
    class Program
    {
        static void Main(string [] args)
        {
            Class1 c = new Class1();
            try
            {
                c.P1 = 120;
            }
            catch (InvalidBasicException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();

            }

        }
    }
    class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set { 
                if(value < 100)
                p1 = value;
                else
                {
                    // Console.WriteLine("Invalid input for p1");
                    //throw new Exception("Invalid input for p1");
                    Exception ex;
                    //ex = new Exception();
                    // ex = new Exception("Invalid Input");
                    ex = new InvalidBasicException("Invalid Input");
                    throw ex;

                }
                
            }
        }
    }
    class InvalidBasicException : ApplicationException
    {
        public InvalidBasicException(string message):base(message)// passing message to base class contr which will print the message for us
        {

        }
    }
}