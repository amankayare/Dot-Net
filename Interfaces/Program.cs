using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class Test : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Test - Delete()");
        }

        public void Insert()
        {
            Console.WriteLine("Test - Insert()");
        }

        public void Update()
        {
            Console.WriteLine("Test - Update()");
        }
        public void MyMethod()
        {
            Console.WriteLine("Test - MyMethod()");
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Test o = new Test();
           // First way of calling
            o.Delete();
            o.Insert();
            o.Update();
            o.MyMethod();

            // Second way of calling
            IDbFunctions oIDb;
            oIDb = o;

            oIDb.Insert();
            oIDb.Delete();
            oIDb.Update();
            // oIDb.MyMethod(); // This method is not available when we use this way to create an object with reference as Interface
        
            // Third way of calling
            // here implicitly reference is created . Casting is used to create implecit reference
            ((IDbFunctions)o).Insert();
            ((IDbFunctions)o).Delete();
            ((IDbFunctions)o).Update();
            // ((IDbFunctions)o).MyMethod(); // This method is not available when we use this way to create an object with reference as Interface

            
        }
    }
}


namespace Interfaces2
{
    // Here one Interface is implemented by two independent classes Test1 and Test2
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class Test1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Test1 - Delete()");
        }

        public void Insert()
        {
            Console.WriteLine("Test1 - Insert()");
        }

        public void Update()
        {
            Console.WriteLine("Test1 - Update()");
        }
        public void MyMethod()
        {
            Console.WriteLine("Test1 - MyMethod()");
        }
    }
    public class Test2 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Test2 - Delete()");
        }

        public void Insert()
        {
            Console.WriteLine("Test2 - Insert()");
        }

        public void Update()
        {
            Console.WriteLine("Test2 - Update()");
        }
        public void MyMethod()
        {
            Console.WriteLine("Test2 - MyMethod()");
        }
    }
    class Program
    {
        static void Main2(string[] args)
        {
            Test1 o = new Test1();
            Test2 o2 = new Test2();

            // First way of calling
            o.Delete();
            o.Insert();
            o.Update();
            o.MyMethod();

            o2.Delete();
            o2.Insert();
            o2.Update();
            o2.MyMethod();

            // Second way of calling
            IDbFunctions oIDb;
            oIDb = o;
            oIDb.Insert();
            oIDb.Delete();
            oIDb.Update();
            // oIDb.MyMethod(); // This method is not available when we use this way to create an object with reference as Interface

            oIDb = o2;
            oIDb.Insert();
            oIDb.Delete();
            oIDb.Update();
            // oIDb.MyMethod(); // This method is not available when we use this way to create an object with reference as Interface

            // Third way of calling
            // here implicitly reference is created . Casting is used to create implecit reference
            ((IDbFunctions)o).Insert();
            ((IDbFunctions)o).Delete();
            ((IDbFunctions)o).Update();
            // ((IDbFunctions)o).MyMethod(); // This method is not available when we use this way to create an object with reference as Interface

            ((IDbFunctions)o2).Insert();
            ((IDbFunctions)o2).Delete();
            ((IDbFunctions)o2).Update();
            // ((IDbFunctions)o2).MyMethod(); // This method is not available when we use this way to create an object with reference as Interface


            // calling general purpose Method which ca take refernce of both classes which is implementing  IDbFunctions interface 
            Test1 t1 = new Test1();
            Test2 t2 = new Test2();
            InsertMethod(t1);
            InsertMethod(t2);



           
        }
        // general purpose method this will work for all classes which impliments IDbFunctions interface 
        static void InsertMethod(IDbFunctions oIDb)
        {
            oIDb.Insert();
        }
    }
}
namespace Interfaces3
{
    // Both interface have same Delete() method and Test is implementing both Interfaces so there is conflict . To solve this implenenbt all member explicitly

    public interface IDbFunctions1
    {
        void Insert();
        void Update();
        void Delete();
    }
    public interface IDbFile
    {
        void Open();
        void Close();

        void Delete();
    }

    public class Test : IDbFunctions1 , IDbFile
    {
   

        public void Delete()
        {
            Console.WriteLine("IDbFunctions1 - Delete()");
        }
        public void Insert()
        {
            Console.WriteLine("IDbFunctions1 - Insert()");
        }
        public void Update()
        {
            Console.WriteLine("IDbFunctions1 - Update()");
        }
        // explicitly implemented methods cant have access specifier and by default they are private
        void IDbFile.Close()
        {
            Console.WriteLine("IDbFile - Update()");
        }
        // explicitly implemented methods cant have access specifier and by default they are private

        void IDbFile.Delete()
        {
            Console.WriteLine("IDbFile - Delete()");
        }
        // explicitly implemented methods cant have access specifier and by default they are private

        void IDbFile.Open()
        {
            Console.WriteLine("IDbFile - Open()");
        }
    }

    class Program
    {
        static void Main3(string [] args)
        {
            Test o = new Test();
            o.Delete();
            o.Insert();
            o.Update();
            //  o.Close(); // not available
            //  o.Open(); // not available
            //  o.Delete(); // not available

            IDbFile dbFile;
            dbFile = o;

            dbFile.Close();
            dbFile.Delete();
            dbFile.Open();
            //   dbFile.Insert();// not available
            //   dbFile.Update();// not available
            Console.ReadLine();
        }

    }
}

namespace InterfacesInheritance
{
    public interface Person
    {
        void Name();
        void Address();
        void Dob();

    }
    public interface Player : Person
    {
        void TotalRecords();
    }
    public class Cricketer : Player

    {
        public void Address()
        {
            Console.WriteLine("Address()");   
        }

        public void Dob()
        {
            Console.WriteLine("Dob()");
        }

        public void Name()
        {
            Console.WriteLine("Name()");
        }

        public void TotalRecords()
        {
            Console.WriteLine("TotalRecords()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cricketer cr = new Cricketer();
            cr.Address();
            cr.Dob();
            cr.Name();
            cr.TotalRecords();
            Console.ReadLine();

        }

    }
}
