using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AsynCode_With_Delegates
{
    /*
      # Why to use MultiThreading?
      - To make our UI active even when some multiple processes are running in backgrounds
      - To do multi tasking
      - To reduce execution time

      # There are different ways in .Net to implement multithreading
        1. using delegates
        2. System.Threading
        3. System.Threading.Task
     
     */
    class Program
    {
        // Synchronous Code
        static void Main1(string[] args)
        { 
            Console.WriteLine("Before");
            Action o = Display;
            o();
            Console.WriteLine("After");
            Console.ReadLine();
        }
        // BeginInvoke() method of delegate
        static void Main2(string[] args)
        {
            Console.WriteLine("Before");
            Action o = Display;
            o.BeginInvoke(null,null); //  This will enable to not wait for display method to completed but skip it and execute next line of codes
                                       // i.e. it will run this line in a seperate thread
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay()");
        }
    }
}



namespace AsynCode_With_Delegates_And_Method_With_Parameter
{
  
    class Program
    {
        
        // BeginInvoke() method of delegate
        static void Main3(string[] args)
        {
            Console.WriteLine("Before");
            Action<string> o = Display;
            o.BeginInvoke("Aman",null, null); //  This will enable to not wait for display method to completed but skip it execute next line codes
                                           // last 2 para is always async callback and object -> null , null
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static void Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay(): "+s);
        }
    }
}

namespace AsynCode_With_Delegates_And_Method_With_Parameter_And_Return_Type_Using_External_CallBack_Function
{

    class Program
    {
        static Func<string, string> o = Display; // we are making delegate global to get access of it inside the MyCallBack() method but its not a good idea
                                                    // instead we can use anonymous method to access delegate object which is shown in next namespace
        static void Main4(string[] args)
        {
            Console.WriteLine("Before");
           // Func<string,string> o = Display;
            
            o.BeginInvoke("Aman", MyCallBack ,null);//  misscall -> callback Function  
            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay(): " + s);
            return s.ToUpper()+" Hello";
        }
        /* 
          This method can be passed as callback method in BeginInvoke as a parameter but object of delegate is not available here therefore need
          to make delegates as Global objects
        */
         static void MyCallBack(IAsyncResult ar)
        {
            Console.WriteLine("Callback() called ");

            string returnedValue = o.EndInvoke(ar);
            Console.WriteLine("returnedValue from Display in Callback function");

        }

    }
}


namespace AsynCode_With_Delegates_And_Method_With_Parameter_And_Return_Type_Using_Anonymous_Method_And_Lambda_Function
{

    class Program
    {
        
        static void Main5(string[] args)
        {
            Console.WriteLine("Before");
            Func<string, string> o = Display;
            /* using anonymous method
            o.BeginInvoke("Aman", delegate (IAsyncResult ar) { 

                string returnedValue = o.EndInvoke(ar);
                Console.WriteLine("returnedValue from Display in anonymous method: " + returnedValue);

            }, null);
            */

            // using lambda function
            o.BeginInvoke("Aman",(IAsyncResult ar) => {

                string returnedValue = o.EndInvoke(ar);
                Console.WriteLine("returnedValue from Display in Lambda function: " + returnedValue);

            }, null);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay(): " + s);
            return s.ToUpper() + " Hello";
        }
        
    }
}

namespace Passing_String_Parameters_To_CallBack_Function
{

    class Program
    {

        static void Main5(string[] args)
        {
            Console.WriteLine("Before");
            Func<string, string> o = Display;

            // here we are using old way by passing method name of callback func
            IAsyncResult arr = o.BeginInvoke("Aman", MyCallBack, "callback para meter as string");// passing string as callback para and BeginInvoke returning IAsyncResult 
            string returnedValue = o.EndInvoke(arr);
            Console.WriteLine("retuned value from display in callback: "+returnedValue);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay(): " + s);
            return s.ToUpper() + " Hello";
        }
        static void MyCallBack(IAsyncResult ar)
        {
            string callBackPara = ar.AsyncState.ToString();//so whatever we passed in last parameter of BeginInvoke() will be recieved as formal para of
                                                           // callback function i.e. IAsyncResult ar and by using property called AsyncState we are extracting it.


            Console.WriteLine("Callback() called: "+callBackPara);
        }

    }
}


namespace Passing_Delegate_As_Parameters_To_CallBack_Function
{

    class Program
    {

        static void Main6(string[] args)
        {
            Console.WriteLine("Before");
            Func<string, string> o = Display;

            // here we are using old way by passing method name of callback func
            IAsyncResult arr = o.BeginInvoke("Aman", MyCallBack, o);// passing delegate obj as callback para
            // now no need to to EndInvoke here as we are getting retured value in callback function itself -> string returnedValue = o.EndInvoke(arr);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay(): " + s);
            return s.ToUpper() + " Hello";
        }
        static void MyCallBack(IAsyncResult ar)
        {
            Console.WriteLine("Callback() called: ");

            // we are getting delegate object as a para therefore need to cast it into respective delegate type
            // here delegate is  Func<string, string> 

            Func<string, string> o = (Func<string, string>)ar.AsyncState;//so whatever we passed in last parameter of BeginInvoke() will be recieved as formal para of
                                                                         // callback function i.e. IAsyncResult ar and by using property called AsyncState we are extracting it


            // now we have delegate object in this function so we can call EndEnvoke() on that object and pass IAsyncResult obj as a parameter to get the return value
            string returndValue = o.EndInvoke(ar);
            Console.WriteLine("retuned value from Display in callback using delegate as Para: "+returndValue);
        }

    }
}



namespace Passing_Null_As_Parameter_To_CallBack_Function_And_Get_Delegate_Object_In_CallBack_Function_Via_AsyncResult
{

    class Program
    {

        static void Main7(string[] args)
        {
            Console.WriteLine("Before");
            Func<string, string> o = Display;

            // here we are using old way by passing method name of callback func
            IAsyncResult arr = o.BeginInvoke("Aman", MyCallBack, null);// passing null as callback para
            // now no need to to EndInvoke here as we are getting retured value in callback function itself -> string returnedValue = o.EndInvoke(arr);

            Console.WriteLine("After");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay(): " + s);
            return s.ToUpper() + " Hello";
        }
        static void MyCallBack(IAsyncResult ar)
        {
            Console.WriteLine("Callback() called: ");

            // we are getting null as a para therefore we dont have delegate object inside this callback function but we need delegate object
            // to call EndInvoke so to get delagate object we are using AsyncResult obj
            // not using IAsyncResult but AsyncResult obj to get delegate object -> xxxxx  Func<string, string> o = (Func<string, string>)ar.AsyncState;

            AsyncResult result = (AsyncResult)ar; // Getting AsyncResult object using IAsyncResult obj

            Func<string, string> o = (Func<string,string>)result.AsyncDelegate; // getting delegate obj using AsyncResult
            string returndValue = o.EndInvoke(ar);
            Console.WriteLine("retuned value from Display in callback using AsyncResult as Para: " + returndValue);
        }

    }
}


namespace Holding_Output_Console_Using_IAsyncResult_Methods_Without_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before");
            Action o = Display;
            IAsyncResult arr = o.BeginInvoke(null, null); //  This will enable to not wait for display method to completed but skip it and execute next line of codes
                                       // i.e. it will run this line in a seperate thread
            Console.WriteLine("After");
            //Console.ReadLine(); // if we remove this line then console will not wait for async code to compete its execution and closed it
            // while (!arr.IsCompleted) ; 1st way of holding , keeps continue checking method execution is over or not
             arr.AsyncWaitHandle.WaitOne(); // waiting for the complete execution of async method , the method will inform that its over
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Dispay()");
        }
    }
}


//calling a method with parameters asynchronously using delObj.BeginInvoke(....
//also using a callback func ( as an anon method - to enable us to access objDel in the callback func ) 
//get the return value with objDel.EndInvoke
// EndInvoke() can be called only once