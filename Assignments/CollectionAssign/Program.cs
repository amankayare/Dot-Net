using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> dicObj = new Dictionary<int, Employee>();
            string ch = "yes";
            while (ch == "yes")
            {
                Employee.insertEmployee(dicObj);
                Console.Write("Do you Want to continue type (yes/no) : ");
                ch = Convert.ToString(Console.ReadLine());

            }

            Employee.empSearch(dicObj);


            Employee.highSalary(dicObj);


            Employee.nthEmpSearch(dicObj);


            Console.ReadLine();

        }

    }


    class Employee
    {
        private int empId;

        private string empName;
        private decimal empSal;
        public static int key = 0;
        public int EmpId
        {
            set
            {
                if (value > 0)
                    empId = value;
                else
                    Console.WriteLine("Enter Valid empId");
            }

            get
            {
                return empId;
            }
        }
        public string EmpName
        {
            set
            {
                if
                    (value == null)
                    Console.WriteLine("Enter Valid empName");
                else
                    empName = value;
            }
            get
            {
                return empName;
            }
        }
        public decimal EmpSal
        {
            set
            {
                if (value < 10000)
                    Console.WriteLine("Enter valid Emp sal ");
                else
                    empSal = value;
            }
            get
            {
                return empSal;
            }
        }

        public Employee(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }

        public static void insertEmployee(Dictionary<int, Employee> dic)
        {


            Console.Write("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            string empName = Console.ReadLine();
            Console.Write("Enter Employee Sal : ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());
            dic.Add(++key, new Employee(empId, empName, empSal));
        }

        public static void highSalary(Dictionary<int, Employee> dic)
        {

            decimal max = 0;
            foreach (KeyValuePair<int, Employee> kvp in dic)
            {
                if (kvp.Value.empSal > max)
                {
                    max = kvp.Value.empSal;
                }

            }
            Console.WriteLine("highest salary =" + max);


            foreach (KeyValuePair<int, Employee> kvp in dic)
            {

                if (kvp.Value.empSal == max)
                {
                    Console.WriteLine(kvp.Key + " :==> " + kvp.Value.EmpId + "  " + "  " + kvp.Value.EmpName + "  " + kvp.Value.EmpSal);
                }
            }
        }
        public static void empSearch(Dictionary<int, Employee> dic)
        {
            Console.Write("Enter the Employee Number to search : ");
            int Searchid = Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<int, Employee> kvp in dic)
            {
                if (Searchid == kvp.Value.EmpId)
                    Console.WriteLine(kvp.Key + " :==> " + kvp.Value.EmpId + "  " + "  " + kvp.Value.EmpName + "  " + kvp.Value.EmpSal);

            }
        }

        public static void nthEmpSearch(Dictionary<int, Employee> dic)
        {
            Console.WriteLine("Enter the nth no of employee:");
            int SearchNth = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            foreach (KeyValuePair<int, Employee> kvp in dic)
            {
                if (SearchNth == count)
                {
                    Console.WriteLine(kvp.Key + " :==> " + kvp.Value.EmpId + "  " + "  " + kvp.Value.EmpName + "  " + kvp.Value.EmpSal);
                }
                count++;
            }
        }
    }
}


namespace Question2
{
    class Program
    {
        static void Main2()
        {
            Emp1[] arr1 = new Emp1[3];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter empno ");
                int EMPNO = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter salary");
                decimal SALARY = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Name ");
                string NAME = Console.ReadLine();
                arr1[i] = new Emp1();
                arr1[i].EMPNO = EMPNO;
                arr1[i].SALARY = SALARY;
                arr1[i].NAME = NAME;
            }
            Console.WriteLine("array");
            foreach (Emp1 a in arr1)
            {
                Console.WriteLine(a.EMPNO + " " + a.SALARY + " " + a.NAME);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<Emp1> l1 = arr1.ToList<Emp1>();
            Console.WriteLine("List ");
            foreach (Emp1 l in l1)
            {
                Console.WriteLine(l.EMPNO + " " + l.SALARY + " " + l.NAME);
            }
            Console.ReadLine();
        }
    }

    public class Emp1
    {

        public int EMPNO
        {
            set; get;
        }
        public decimal SALARY
        {
            set; get;
        }

        public string NAME
        {
            set; get;
        }
    }
}



namespace Question3
{
    class Program
    {
        static void Main3()
        {
            List<Emp2> list = new List<Emp2>();
            list.Add(new Emp2 { EMPNO = 1, SALARY = 400000, NAME = "a" });
            list.Add(new Emp2 { EMPNO = 2, SALARY = 600000, NAME = "b" });


            object[] arr = list.ToArray();

            foreach (Emp2 e in arr)
            {
                Console.WriteLine(e.EMPNO + " " + e.SALARY + " " + e.NAME);
            }
            Console.ReadLine();
        }
    }

    public class Emp2
    {

        public int EMPNO
        {
            set; get;
        }
        public decimal SALARY
        {
            set; get;
        }

        public string NAME
        {
            set; get;
        }
    }
}