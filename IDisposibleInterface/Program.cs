using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWayIDisposibleInterface
{
    class Program
    {
        static void Main1(string[] args)
        {
            Test1 t1 = new Test1();
            t1.Play();
            t1.Dispose(); //  resources are release
            t1.Play(); // Resources are already freed so this line should not work
            Console.ReadLine();
        }
    }
    public class Test1 : IDisposable
    {
        private bool isDisposed = false;
        public void Play()
        {
            CheckForDisposed();
            Console.WriteLine("Play");
        }
        private void CheckForDisposed()
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException("Test 1");
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed() is called ... Free all resources.");
            isDisposed = true;
        }

    }
    // In this simple way we can  also do it without implementing Disposible Interface with our simple Dispose Method so what Disposible Interface is giving us is that 
    // we can use using( ){---} block and we need not to call dispose method explicitly which is shown in next namespace
}
namespace IDisposibleInterfaceUsingBlock
{

   
    public class Test1 : IDisposable
    {
        private bool isDisposed = false;
        public void Play()
        {
            CheckForDisposed();
            Console.WriteLine("Play");
        }
        private void CheckForDisposed()
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException("Test 1");
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed() is called ... Free all resources.");
            isDisposed = true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            using (Test1 t1 = new Test1())
            {
                t1.Play();

            } // after this line Dispose method get called automatically
              //  t1.Play(); // Resources are already freed so this line should not work
            Console.ReadLine();
        }
    }

}