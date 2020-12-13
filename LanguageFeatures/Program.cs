using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitVariables
{
    class Program
    {
        static void Main1(string[] args)
        {
            int i; // variable i is of type int
            var i2 = 100; // implicit variable -> datatype of i2 is kept up according to what is asigned to it
                          // i2 = "abc"; // now this is not allowed becoz once you assigned a datatype then you cant change it 

            // var i; // not allowed becoz if we dont assign anything compliler will not be able to assign the datatype based on what we have assigned

            i2 = (short)10; // This is disadvantage of using implicit variables 
            Console.WriteLine(i2.GetType().ToString());

            
            SortedList<int, string> obj = new SortedList<int, string>();
            foreach(var item in obj) // by looking at var we cant predict what type we are using so less readble
            {
                    
            }


            /*
             - Var used only for local variables 
             - cant be used for class level variables , method parameter and return type
             
             */
            Console.ReadLine();
        }
    }
}

namespace ObjectInitailizer
{
    class Program
    {
        static void Main2(string[] args)
        {



            /* TODO */
            Console.ReadLine();
        }
    }
}

// same as anonymous Class i.e. is type (class) which dont have name
namespace AnonymousType
{
    class Program
    {
        static void Main3(string[] args)
        {
            //Class1 o = new class1{ i =123 , j = 654}; // object initialzer looks same
            var mycar = new {Color="red" , Model = "Ferari" , Version="v1" , Speed=10 };// mycar is object of the anonymous class with object initailzer syntax

            var mycar2 = new { Color = "blue", Model = "Lambo", Version = "g1", Speed = 100 };

            Console.WriteLine("{0}{1}{2}",mycar.Color,mycar.Model,mycar.Speed);
            Console.WriteLine("{0}{1}{2}", mycar2.Color, mycar2.Model, mycar2.Speed);
            /*
             - if both anonymous type have identical properties then comipler will generate only one type object 
             - for confirming we are trying to print there type 
             
             */
            Console.WriteLine(mycar.GetType().ToString());
            Console.WriteLine(mycar2.GetType().ToString());

            var mycar3 = new { Color = "black", Name = "Lambo", Version = "g1", Speed = 100 };
            Console.WriteLine(mycar3.GetType().ToString());// For this new anonymous type will be created

            Console.ReadLine();
        }
    }
}

// it allows us to write extra methods for existing class , structs  
namespace ExtensionMethod
{
    class Program
    {
        static void Main4(string[] args)
        {
            int i = 123;
            string s = "aman";

            Console.ReadLine();
        }

        // suppose this reverse method is often we use .. 
        static int Reverse(int i)
        {
            int reverse = 321;
            // some code goes here
            return reverse;
        }
    }
    // making our extention method
    static class Program2 // making static class
    {
        static void Main5(string[] args)
        {
            int i = 123;
            i.Display(); // now Display is available for all int type variable
                         // internaly converted into  -->  Program2.Display(i); 

            string s = "aman";
            s.Show();// now show is available for all string type variable .  // internaly converted into  -->  Program2.Show(s); 

            s.MethodWithPara(200);// For parameters wala extension methods actual parameter are always 1 less then formal para
                                   // i.e. first argument is automatically taken by compiler as given in formal parameters
            Console.ReadLine();
        }

        public static void Display(this int a)// making static method
        {
            Console.WriteLine("Display() -- extention method: "+a);
        }
        public static void Show(this string a)// making static method
        {
            Console.WriteLine("Show() -- extention method: " + a);
        }
        public static void MethodWithPara(this string a , int b)// making static method
        {
            Console.WriteLine("Show() -- extention method: " + a +" ->"+b);
        }
    }
}

namespace ExtensionMethodForBaseClass
{
    
    // making our extention method
    static class Program // making static class
    {
        static void Main6(string[] args)
        {
            int i = 123;
            i.Display(); // Display() available for int even extention method is written for object class(Base Class)

            string s = "Aman";
            s.Display();// Display() available for string class also as extention method is written for object class(Base Class)

            Console.ReadLine();
        }

        public static void Display(this object a)// making static method
        {
            Console.WriteLine("Display() -- extention method: " + a);
        }
       
    }
}




namespace ExtensionMethodForInterFace
{

    /* TO DO */
    public interface IMathOperation
    {
        int Add(int a, int b);
        int Mult(int a, int b);
    }

    public class MyMaths : IMathOperation
    {

        public int Add(int a, int b)
        {
            return a + b;
        }
         public int Mult(int a, int b)
        {
            return a * b;
        }
    }
    public static class MyExtensionClass
    {
        static void Main(string[] args)
        {
            IMathOperation o = new MyMaths();
            o.MyExtendedMethod();

            Console.ReadLine();
        }
        public static void MyExtendedMethod(this IMathOperation obj)
        {
            Console.WriteLine("MyExtendedMethod: "+obj.Add(10,30));
        }
    }
}





    /*
    - To make a Extension method we have to create a static class and static method
    - The first parameter of the method should be of type for which we are making extention method
    - Before 1st parameter use 'this' keyword
    - An extension method written for base class is also available for all derived class 
    - We can write a  Extention methods for interface also and it will be availble for all the classes which implemented its
     */



    namespace PartialClasses
{
    // we can divide our class into multi parts(classes) and  when we try to execute it, the compiler will merge all parts and complies it and produce result
    
    public partial class Class1
    {
        public int i;
    }
    public partial class Class1
    {
        public int j;
    }



    class Program
    {
        static void Main7(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine(obj.i);// obj have i 
            Console.WriteLine(obj.j);// obj have j also
            Console.ReadLine();
        }
    }
}


/*
 Some rules for partial classes
- partial classes must be in same namespace
- partial classes must be in same assembly(project)
- partial classes must have same name
- we can have as many as partial classes (No Limits)

 
 */



namespace PartialMethods
{
    // 
    // This class is written by 1st person who is creating place holders
    public partial class Class1
    {
        private bool isValid = true;
        partial void Validation();// we are creating a placeholder

        public bool Check()
        {
            Validation(); // we are placing our placeholder here so that someone will come and implement the Validate()
                          // so if nobody gave the implementation and if we are compiling the code compiler will remove all
                          // traces of Validation() method and we can check in IL code
            return isValid;

        }
    }

    // This class is written by 2nd person who is removing place holders and implementing the partial method
    public partial class Class1
    {
        partial void Validation()// 2nd person have come and removing the place holder and implementing the Validation()
        {
            isValid = false;

        }

        static void Main9(string[] args)
        {
            Class1 obj = new Class1();
            obj.Validation();
            Console.WriteLine(obj.isValid);

            Console.ReadLine();
        }
    }

}

    
/*
 Some rules for Partial methods
 - partial methods are allowed in partial classes only 
 - partial methods always return void
 - partial methods implicitly private means even you cant specify it private
 - out parametrs are not allowed in partial methods

 */