using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager("Aman", 4, "project manager", 12000);
            Employee e2 = new GeneralManager("Arpit", 5, "CEO", "Ram", 50000);
            Employee e3 = new CEO("Sunder", 6, 1100000);

            Console.WriteLine(e1.CalacNetSalary());
            Console.WriteLine(e2.CalacNetSalary());
            Console.WriteLine(e3.CalacNetSalary());

            e1.Play();
            e1.Stop();

            e2.Play();
            e2.Stop();

            e3.Play();
            e3.Stop();

            Console.ReadLine();

        }
    }

    public interface IDbFunctions
    {
        void Play();
        void Stop();
    }

    abstract class Employee : IDbFunctions
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
            private set { 
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
        protected decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
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
        public abstract decimal CalacNetSalary();

        public virtual void Play()
        {
            Console.WriteLine("Employee -> Play()");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Employee -> Stop()");
        }

        #endregion


    }
    class Manager : Employee , IDbFunctions
    {
        private string designation;

        public string Designation
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("name can't be blank");
                }
                else
                {
                    designation = value;

                }
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic
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
        public Manager(string Name, short DeptNo, string Designation = "manager", decimal Basic = 0) : base(Name, Basic,DeptNo)
        {

            this.Designation = Designation;

        }
        public override decimal CalacNetSalary()
        {

            return Basic + 10;
        }
        public override void Play()
        {
            Console.WriteLine("Manager -> Play()");
        }

        public override void Stop()
        {
            Console.WriteLine("Manager -> Stop()");
        }


    }

    class GeneralManager : Manager
    {
        private string perks;

        public string Perks
        {
            set
            {
               perks = value;
                
            }
            get
            {
                return perks;
            }
        }
        public override decimal Basic
        {
            set
            {
                basic = value;
            }
            get
            {
                return basic;
            }
        }

        public GeneralManager(string Name, short DeptNo, string Designation, string Perks, decimal Basic) : base(Name,  DeptNo, Designation, Basic)
        {
            this.Perks = Perks;
        }
        public override decimal CalacNetSalary()
        {
            return Basic+20;

        }
        public override void Play()
        {
            Console.WriteLine("GeneralManager -> Play()");
        }

        public override void Stop()
        {
            Console.WriteLine("GeneralManager -> Stop()");
        }
    }

    class CEO : Employee
    {
        public override decimal Basic
        {
            set
            {
                basic = value;
            }
            get
            {
                return basic;
            }
        }
        public CEO(string Name, short DeptNo, decimal Basic) : base(Name, DeptNo)
        {
            this.Basic = Basic;
        }
        public sealed override decimal CalacNetSalary()
        {
            return Basic + 30;

        }
        public sealed override void Play()
        {
            Console.WriteLine("CEO -> Play()");
        }

        public sealed override void Stop()
        {
            Console.WriteLine("CEO -> Stop()");
        }
    }
}
