using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public sealed class Myclass
    {
        public void Display()
        {
            Console.WriteLine("My Display()");
        }
        public void Play()
        {
            Console.WriteLine("My Play()");
        }
    }
  /*
    public class Child : Myclass
    {
        
    }
   Here we are trying to inherit from a sealed class i.e Myclass so this is not allowed means we can not inherit from sealed class
  */
    class Program
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass(); // We are allowed to create object of an sealed class
            m.Display();
            m.Play();
            Console.ReadLine();
        }
    }
}
/*
 
Can Instantiate		Can Inherit from
Abstract Class		NO			        YES
Sealed Class		YES			        NO

 */