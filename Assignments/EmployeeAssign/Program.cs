using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            
                        Console.WriteLine(o1.EmpNo);
                        Console.WriteLine(o2.EmpNo);
                        Console.WriteLine(o3.EmpNo);

                        Console.WriteLine(o3.EmpNo);
                        Console.WriteLine(o2.EmpNo);
                        Console.WriteLine(o1.EmpNo);
            

      

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
            private set // property Accessor 
            {   
                empNo = value;
            }
        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if(value < 50 || value > 100)
                {
                    Console.WriteLine("Basic should be between 50-100");
                }
                else
                {
                    basic = value;
                }
            }
            get
            {
                return basic;

            }
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if(value <= 0)
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
        #endregion

        #region Constructors
       
        public Employee(string Name ="Default Name" , decimal Basic = 51, short DeptNo = 1)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            this.EmpNo = ++counter;

        }
       
        #endregion
        #region Methods
        public decimal GetNetSalary()
        {
            decimal tax = 100;
            decimal houseAllowance = 1000;
            decimal provident = 500;
            return this.Basic + tax + houseAllowance + provident;
        }
        #endregion


    }


}
