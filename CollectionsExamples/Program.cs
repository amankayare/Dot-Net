using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExamples
{
    class Program
    {
        static void Main1(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(10);
            arrList.Add("Aman");
            arrList.Add(30.2);
            arrList.Add(true);

            foreach(Object item in arrList){
                Console.WriteLine(item);
            }
            Console.ReadLine();

            arrList.Remove(10);
            arrList.RemoveAt(1);

            foreach (Object item in arrList)
            {
                Console.WriteLine(item);
            }

            //arrList.AddRange(arrList2);

            int pos = arrList.IndexOf(true);
            int lPos = arrList.LastIndexOf(true);

            arrList.Capacity = 100;
            // arrList.Clear(); //  remove All

            bool found = arrList.Contains(10);

            //arrList.CopyTo(anotherArray);
            
            arrList.BinarySearch(10);

            arrList.Insert(0, "a");

            arrList.RemoveRange(2, 1);

            // Object[] arr = arrList.ToArray(); // similar to copyTo() but difference is that it returns a new array but in copyTo we need to pass array as parameter

            // arrList.TrimToSize(); // Genereally it uses with the Capacity method to trim extra memory
            Console.ReadLine();
            
            
            
            }
    }
}
namespace HashTableExample
{
    class Program
    {
        static void Main2(string[] args)
        {
            Hashtable objDic = new Hashtable();
            objDic.Add(1,"abc");
            objDic.Add(2, "pqr");
            objDic.Add(3, "xyz");

            objDic[3] = "new value"; // if key is already present then override it otherwise create new key value pair
            objDic[4] = "aabbcc";

            foreach (DictionaryEntry item in objDic)
            {
                Console.WriteLine(item.Key+"--"+item.Value); // order of insertion is not maintained
            }

            objDic.Remove(2); // 2 is the key
            // objDic.Clear(); // remove all
            objDic.Contains(3);// it contains the key or not
            objDic.ContainsKey(3);// it contains the key or not same as Contains()
            Console.ReadLine();
        }
    }
   
}

namespace SortedListExample
{
    class Program
    {
        static void Main3(string[] args)
        {
            SortedList objDic = new SortedList();
            objDic.Add(1, "abc");
            objDic.Add(2, "pqr");
            objDic.Add(3, "xyz");

            objDic[3] = "new value"; // if key is already present then override it otherwise create new key value pair
            objDic[4] = "aabbcc";

            foreach (DictionaryEntry item in objDic)
            {
                Console.WriteLine(item.Key + "--" + item.Value); // order of insertion is not maintained
            }

            objDic.Remove(2); // 2 is the key
            // objDic.Clear(); // remove all
            objDic.GetByIndex(0);
            ArrayList objKey = (ArrayList)objDic.GetKeyList();
            objDic.IndexOfKey(2);
            SortedList sortedObjKey = (SortedList)objDic.Keys;
            objDic.Contains(3);// it contains the key or not
            objDic.ContainsKey(3);// it contains the key or not same as Contains()
            Console.ReadLine();
        }
    }

}

namespace StakeExample
{
    class Program
    {
        static void Main4(string[] args)
        {
            Stack st = new Stack();
            st.Push(100);
            st.Push(200);
            st.Push(300);
            st.Push(400);

            Console.WriteLine("PEEK: "+st.Peek());
            Console.WriteLine("POP:"+st.Pop());
            Console.ReadLine();
        }
    }

}

namespace QueueExample
{
    class Program
    {
        static void Main4(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(100);
            qu.Enqueue(200);
            qu.Enqueue(300);
            qu.Enqueue(400);


            Console.WriteLine("PEEK: " + qu.Peek());

            Console.WriteLine( qu.Dequeue() );
                        
            Console.ReadLine();
        }
    }

}


namespace GenericListExamples
{
    class Program
    {
        static void Main5(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            list.Remove(10);
            list.RemoveAt(1);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            //arrList.AddRange(arrList2);

            int pos = list.IndexOf(20);
            int lPos = list.LastIndexOf(30);

            list.Capacity = 100;
            // arrList.Clear(); //  remove All

            bool found = list.Contains(10);

            //arrList.CopyTo(anotherArray);

            list.BinarySearch(10);

            list.Insert(0, 10);

            list.RemoveRange(2, 1);

            // Object[] arr = arrList.ToArray(); // similar to copyTo() but difference is that it returns a new array but in copyTo we need to pass array as parameter

            // arrList.TrimToSize(); // Genereally it uses with the Capacity method to trim extra memory
            Console.ReadLine();



        }
    }
}



namespace GenericSortedListExamples
{
    class Program
    {
        static void Main5(string[] args)
        {
            SortedList<int,string> list = new SortedList<int,string>();
            list.Add(1,"pqr");
            list.Add(2,"xyz");
            list[3] = "abc";
            foreach (KeyValuePair<int,string> item in list)
            {
                Console.WriteLine(item.Key+" "+item);
            }
            Console.ReadLine();

            list.Remove(10);
            list.RemoveAt(1);

            foreach (KeyValuePair<int, string> item in list)
            {
                Console.WriteLine(item);
            }

           
            
            Console.ReadLine();



        }
    }
}
namespace GenericStackExample
{
    class Program
    {
        static void Main6(string []ar)
        {

        }
    }
}

namespace GenericQueueExample
{
    class Program
    {
        static void Main7(string[] ar)
        {

        }
    }
}

namespace ObjectInitializer
{
    class Program
    {
        static void Main8(string[] ar)
        {
            List<Employee> ob = new List<Employee>();
/*
            Employee em = new Employee();
            em.EmpNo = 1;
            em.Basic = 1000;
            em.EmpNo = 21;
            em.DeptNo = 54;
            em.Name = "Aman";
            ob.Add(em);
*/

            //Object Initializer
            ob.Add(new Employee { EmpNo = 1, Name = "V", Basic = 1234, DeptNo = 10 });
            ob.Add(new Employee { EmpNo = 2, Name = "X", Basic = 3142, DeptNo = 20 });
            ob.Add(new Employee { EmpNo = 3, Name = "W", Basic = 4323, DeptNo = 30 });
            ob.Add(new Employee { EmpNo = 4, Name = "Z", Basic = 5243, DeptNo = 40 });
            ob.Add(new Employee (5,"new"){Basic = 8431, DeptNo = 50 });// in case of constructor we can do like this


            foreach (Employee em in ob)
            {
                Console.WriteLine(em.Name);
            }

            Console.WriteLine("===================================");


            SortedList<int,Employee> sl = new SortedList<int,Employee>();
            /*
                        Employee em = new Employee();
                        em.EmpNo = 1;
                        em.Basic = 1000;
                        em.EmpNo = 21;
                        em.DeptNo = 54;
                        em.Name = "Aman";
                        sl.Add(1,em);
            */

            //Object Initializer
            sl.Add(1,new Employee { EmpNo = 1, Name = "V", Basic = 1234, DeptNo = 10 });
            sl.Add(2,new Employee { EmpNo = 2, Name = "X", Basic = 3142, DeptNo = 20 });
            sl.Add(3,new Employee { EmpNo = 3, Name = "W", Basic = 4323, DeptNo = 30 });
            sl.Add(4,new Employee { EmpNo = 4, Name = "Z", Basic = 5243, DeptNo = 40 });
            sl.Add(5,new Employee(5, "new") { Basic = 8431, DeptNo = 50 });// in case of constructor we can do like this


            foreach (KeyValuePair<int,Employee> kvp in sl)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value.Name);

            }

        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }
        public int DeptNo { get; set; }

        public Employee(int EmpNo=1,string Name = "DefaultName")
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
        }

    }
}

namespace ListOfEmployees
{
    // we are changing list of Employee to EmployeesList itself
    class Program
    {
        static void Main9(string[] args)
        {
            // List<Empoyee> o = new List<Empoyee>
            Employees empList = new Employees();
        }
    }
    public class Employees : List<Employee>
    {

    }
    public class Employee 
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }
        public int DeptNo { get; set; }

        public Employee(int EmpNo = 1, string Name = "DefaultName")
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
        }

    }
}