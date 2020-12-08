using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    
    class Program
    {
        static void Main1(string[] args)
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
            Console.WriteLine("Enter no. of Batches :");
            int nob = Convert.ToInt32(Console.ReadLine());
            int[][][] arr2 = new int[nob][][];

            for (int i = 0; i < nob; i++)
            {
                Console.WriteLine("Enter no. of Student in batch :" + (i + 1));
                int nos = Convert.ToInt32(Console.ReadLine());
                arr2[i] = new int[nos][];
                for (int j = 0; j < nos; j++)
                {
                    Console.WriteLine("Enter no. Marks for Student :" + (j + 1));
                    arr2[i][j] = new int[3];
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("Enter Mark for Subject :" + (k + 1));
                        arr2[i][j][k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            for (int i = 0; i < nob; i++)
            {
                Console.WriteLine("Student in batch :" + (i + 1));


                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.WriteLine($"Student No. {(j + 1)} Marks : ");
                    for (int k = 0; k < 3; k++)
                    {

                        Console.Write(arr2[i][j][k] + " ");
                    }
                    Console.WriteLine("");
                }
            }


        }



    }
}
namespace Question3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Student[] arr = new Student[5];

            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the name of arr["+i+"]: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Roll of arr[" + i + "]: ");
                int roll = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Marks of arr[" + i + "]: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                arr[i] = new Student(name,roll,marks);
            }

            Console.WriteLine("Details of Students");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The name of arr[" + i + "] Student : "+ arr[i].Name);
                Console.WriteLine("The roll no of arr[" + i + "] Student : " + arr[i].RollNo);
                Console.WriteLine("The marks of arr[" + i + "] Student : " + arr[i].Marks);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
    public struct Student{

        private string name ;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine(" Name Can't be Empty or Null");
                }
                else
                {
                    name = value;
                }
                
            }
        }
        private int rollNo;
        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                if (value < 0 )
                {
                    Console.WriteLine("Roll should be > 0");
                }
                else
                {
                    rollNo = value;

                }
            }
        }

        private decimal marks;
        public decimal Marks
        {
            get
            {
                return marks;
            }
            set
            {
                if(value < 0 || value > 100)
                {
                    Console.WriteLine("Marks should be > 0 and < 100");
                }
                else
                {
                    marks = value;

                }
            }
        }
        public Student(string Name="Default",int RollNo=1,decimal Marks=0)
        {
            this.name = Name;
            this.rollNo = RollNo;
            this.marks = Marks;
        }
    }
}