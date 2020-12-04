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
            Employee[] arr = new Employee[3];


            for (int i = 0; i<arr.Length;i++)
            {
                string name = Console.ReadLine();
                decimal basic = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();
                short deptNo;

                if(short.TryParse(input, out deptNo))
                {
                    arr[i] = new Employee(name, basic, deptNo);

                }
            }
            Employee temp = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].CalacNetSalary() > temp.CalacNetSalary())
                {
                    temp = arr[i];
                }
            }
            Console.WriteLine("Employee with highest Salary");
            Console.WriteLine("EMP No: " + temp.EmpNo);
            Console.WriteLine("NAME: " + temp.Name);
            Console.WriteLine("Dept No: " + temp.DeptNo);
            Console.WriteLine("Basic: " + temp.Basic);
            Console.WriteLine("SALARY: "+ temp.CalacNetSalary());

            Console.WriteLine("Enter EMP No to search Employee");
            int empNo = Convert.ToInt32(Console.ReadLine());

            foreach(Employee emp in arr)
            {
                if(emp.EmpNo == empNo)
                {
                    Console.WriteLine("Emp No: " + emp.EmpNo);
                    Console.WriteLine("Name: " + emp.Name);
                    Console.WriteLine("Basic: " + emp.Basic);
                    Console.WriteLine("Net Salary: " + emp.CalacNetSalary());
                    Console.WriteLine("Dept No: " + emp.DeptNo);
                    break;

                }
            }


            Console.ReadLine();
        }
    }


    class Employee 
    {

        #region Properties
        private static int counter = 0;
        private string name;
        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("name can't be blank");
                }
                else
                {
                    name = value;

                }
            }
            get
            {
                return name;
            }
        }
        private int empNo = 0;
        public int EmpNo
        {   // read only

            get
            {
                return empNo;
            }
            private set
            {
                empNo = value;
            }
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("DeptNo must be > 0");
                }
                else
                {
                    deptNo = value;
                }
            }
            get
            {
                return deptNo;
            }
        }
        private decimal basic;
        public  decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }

        #endregion

        #region Constructors

        public Employee(string Name = "Default Name", decimal Basic = 51, short DeptNo = 1)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            this.EmpNo = ++counter;

        }

        #endregion
        #region Methods
        public  decimal CalacNetSalary()
        {
            return Basic + 1000;
        }

        #endregion


    }
}
namespace Question2
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter no. of batches in CDAC");
            int nob = Convert.ToInt32(Console.ReadLine());

            string[] cdac = new string[nob];

            int nos = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < cdac.Length; i++)
            {
            }


        }
    }
    class Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }

    class Marks
    {
        private int english;
        public int English
        {
            set
            {
                english = value;
            }
            get
            {
                return english;
            }
        }

        private int math;
        public int Math
        {
            set
            {
                math = value;
            }
            get
            {
                return math;
            }
        }
    }
}