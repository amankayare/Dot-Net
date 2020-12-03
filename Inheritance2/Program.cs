using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorCalls
{
    public class Parent
    {
        private int b;
        public Parent()
        {
            Console.WriteLine("Parent 0 para contr");
        }
        public Parent(int b )
        {
            Console.WriteLine("Parent 1 para contr");
            this.b = b;
        }
    }

    public class Child : Parent
    {
        private int c;

        public Child()
        {
            Console.WriteLine("Child 0 para contr");
        }

        public Child(int c)
        {
            Console.WriteLine("Child 1 para contr");
            this.c = c;
        }
        public Child(int c, int b):base(b)
        {
            Console.WriteLine("Child 2 para contr");
            this.c = c;
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            // int i = int.Parse( Console.ReadLine() ); input from console , this method is faster
            // int i = Convert.ToInt32( Console.ReadLine() ); input from console , this method is slower but converting from anytype to anytype is available so recommended

            Parent o = new Parent(); // "Parent 0 para contr"
            Console.ReadLine();

            Parent o2 = new Parent(10); //  "Parent 1 para contr"
            Console.ReadLine();

            Child c = new Child(); // Parent 0 para contr and Child 0 para contr
            Console.ReadLine();

            Child c1 = new Child(10); // Parent 0 para contr and child 1 para contr
            Console.ReadLine();

            Child c2 = new Child(10, 20);// Parent 1 para contr and child 2 para contr
            Console.ReadLine();

            //  Child c3 = new Parent(); Not allowed 

            Parent ob = new Child(); // Parent 0 para contr and  child 0 para contr
            Console.ReadLine();

            Parent ob2 = new Child(10); // Parent 0 para contr and  child 1 para contr
            Console.ReadLine();

            Parent ob3 = new Child(10,20); // Parent 1 para contr and  child 2 para contr
            Console.ReadLine();

        }
    }
}
namespace MethodHiding
{
    //  In method hiding, you can redefine the method of the Parent class in the derived class by using the new keyword.


    public class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent Class Display");
        }
    }
    public class Child : Parent
    {
        /* it will also work withod using new keyword but give warning
        public void Display()
        {
            Console.WriteLine("Child Class Display");
        } */

        // Reimplement the Display method of the Parent class 
        // Using new keyword 
        // It hides the method of the Parent class 
        public new void Display()
        {
            Console.WriteLine("Child Class Display");
        }
    }


    class Program
    {
        static void Main2(string [] args)
        {
            Child c = new Child();
            c.Display(); // Child Class Display ** only in this case method hiding is applied
            Console.ReadLine();// child obj have 2 Display() methods but parent Display() is hided now.


            Parent b = new Parent();
            b.Display(); // Parent Class Display
            Console.ReadLine();// In this case method hiding is not applicable

            Parent o = new Child();
            o.Display(); // Parent Class Display
            Console.ReadLine();// In this case method hiding is not applicable

        }
    }

}
namespace MethodOverLoadingInInheritance
{
    public class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent class Display");
        }
    }
    public class Child : Parent
    {
         public void Display(string arg)
        {
            Console.WriteLine("Child Class Display: "+arg );
        }
    }
    class Program
    {
        static void Main3()
        {
            Child c = new Child();
            c.Display(); // Parent class Display
            c.Display("test"); // Child Class Display: test
            Console.ReadLine();

        }
    }
}
namespace OverridingMethod
{
    class Parent
    {
        public virtual void Play()
        {
            Console.WriteLine("Virtual Parent play(*)");
        }
        public void NonVirtual()
        {
            Console.WriteLine("Parent NonVirtual(*)");

        }
    }
    class Child : Parent
    {
        // Here we are overriding virtual method Play() of Parent Class
        public override void Play()
        {
            Console.WriteLine("Virtual Child Play(*)");
        }
        public void NonVirtual()
        {
            Console.WriteLine("Child NonVirtual(*)");

        }
    }
    class GrandChild : Child
    {
        // here we are again overriding overrided method Play() of Child Class
        // if you make a method 'sealed' then we are not allowed to override further
        public sealed override void Play()
        {
            Console.WriteLine("Grand Child Play(*)");
        }
    }
    class GreatGrandChild : GrandChild
    {
        /*cannot override inherited member 'GrandChild.Play()' because it is sealed		
         
        public  override void Play()
        {
            Console.WriteLine("Grand Child Play(*)");
        }*/

    }
    class Program
    {
        static void Main(string []args)
        {
            Parent p = new Parent();
            p.Play(); // virtual Parent Play(*)
            p.NonVirtual(); // Parent NonVirtual(*)
            Console.ReadLine();

            Child c = new Child();
            c.Play(); // virtual Child Play(*) 
            c.NonVirtual(); // Child NonVirtual(*)
            Console.ReadLine();

            Parent p2 = new Child();
            p2.Play(); // virtual Child Play(*) 
            p2.NonVirtual(); // Parent NonVirtual(*) ** if it was method hiding then parent nonvirtual method would be hided 
                             // since its overriding therefore Parent NonVirtual(*) get called.
                             // and hiding is only applied on child reference and child object
            Console.ReadLine();

            /*
             BaseClass o;               <- non virtual methods depends on this.
             o = new BaseClass;         <- virtual methods depends on this.

            Non virtual methods calling is depends on reference type i.e. if refernce is of Base type then Base class non virtual method get called
            and if reference is of Child Type then Child class non Virtual method will get called.
            
            Virtual methods calling is depends on Object type i.e. if object is of Base type then Base class  virtual method get called
            and if object is of Child type then Child class virtual method will get called.
           
             */

        }
    }
}