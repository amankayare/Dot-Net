using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class  MyAbstractClass
    {
        // abstract class can contain atleast one abstract method or can not be contain its not mandatory in DotNet
        // we cant instantiate abstract class
        public void Display()
        { // concreate method
            Console.WriteLine("MyAbstractClass Display()");
        }
        public void Display2()
        { // concreate method
            Console.WriteLine("MyAbstractClass Display2()");
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            // MyAbstractClass ab = MyAbstractClass(); // not allowed
        }
    }
}
namespace AbstractClassInheritance
{

    abstract class AbstractClass
    {
        public void ConcreteMethod()
        {// concreate method
            Console.WriteLine("Concrete Method in Abstract class ");
        }
        public abstract void Display(); // This abstract method should compulsarily override into its child class otherwise we have to make the child class as abstract

    }
    abstract class Child1 : AbstractClass
    {   // Here we are not overriding the abstract Display() in our child1 wo we have to make Child1  class abstract
        public void Child1Concrete()
        {   // Concrete method
            Console.WriteLine("Child1 Concrete method");
        }
    }
    class Child2 : AbstractClass
    {   // Here we are overriding the abstract Display() in our child2 wo we dont have to make Child2  class abstract
        public override void Display()
        {
            Console.WriteLine("Display() overriden Method");
        }

    }
    public class Program
    {
        static void Main(string [] args)
        {
            // Child1 c = new Child1(); // not allowed
               Child2 c2 = new Child2();
               c2.ConcreteMethod();
               c2.Display();
               Console.ReadLine();

        }
    }
}
/*
 
 			    Can Instantiate		Can Inherit from
Abstract Class		NO			        YES
Sealed Class		YES			        NO

 */