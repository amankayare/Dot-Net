using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static List<Department> lstDept = new List<Department>();
        static List<Employee> lstEmp = new List<Employee>();

        //simple select all Query
        static void Main1(string[] args)
        {
            AddRecords();
            // From SINGLE_OBJECT in COLLECTION select SOMETHING
             var emps = from emp in lstEmp select emp; // loop over each record automatically // This query is similar to select * from lstEmp
           // IEnumerable<Employee> emps = (List<Employee>)from emp in lstEmp select emp;

            // List<Employee> emps = (List<Employee>)from emp in lstEmp select emp;

            foreach(var item in emps)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Basic);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.Gender);
                Console.WriteLine();
                Console.WriteLine();


            }
            Console.ReadLine();
        }



        // simple select Name from emplist
        static void Main2(string[] args)
        {
            AddRecords();
            // From SINGLE_OBJECT in COLLECTION select SOMETHING
            var emps = from emp in lstEmp select emp.Name;  // This query is similar to select Name from lstEmp
            // IEnumerable<string> is return by above query
            // we can take in List<string> but need to type cast as it is returning IEnumerable<string>


            foreach (var item in emps)
            {
                Console.WriteLine(item);
               
                Console.WriteLine();
                Console.WriteLine();


            }
            Console.ReadLine();
        }

        // select Two columns from emplist
        static void Main3(string[] args)
        {
            AddRecords();
            // From SINGLE_OBJECT in COLLECTION select SOMETHING
            var emps = from emp in lstEmp select new { emp.Name, emp.Basic };  // This query is similar to select Name,Basic from lstEmp
           // we are getting two columns i.e.  string , decimal there for we need new class which contains these two properties therefore we needed an anonymous class 
           // which is written using new keyword


            foreach (var item in emps)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Basic);

                Console.WriteLine();
                Console.WriteLine();


            }
            Console.ReadLine();
        }

        // where clause , order by
        static void Main4(string[] args)
        {
            AddRecords();


             var emps1 = from emp in lstEmp where emp.Basic > 12000 select new { emp.Name, emp.Basic };  
            // This query is similar to select Name,Basic from lstEmp where basic > 10000

             var emps2 = from emp in lstEmp where (emp.Basic > 11000 && emp.Basic < 13000) select new { emp.Name, emp.Basic };
            // This query is similar to select Name,Basic from lstEmp where basic > 10000 and basic < 12000

            var emps3 = from emp in lstEmp where (emp.Basic > 11000 || emp.Basic < 13000) select new { emp.Name, emp.Basic };
            // This query is similar to select Name,Basic from lstEmp where basic > 10000 or basic < 12000

            var emps4 = from emp in lstEmp orderby emp.Name ascending select emp;
            // This query is similar to select Name,Basic from lstEmp order by Name

            var emps5 = from emp in lstEmp orderby emp.Name descending select emp;
            // This query is similar to select Name,Basic from lstEmp order by Name desc




            /*  TODO*/
            foreach (var item in emps5)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Basic);

                Console.WriteLine();
                Console.WriteLine();


            }
            Console.ReadLine();
        }
        // JOINS
        static void Main5(string[] args)
        {
            AddRecords();


            var emps1 = from emp in lstEmp join dept in lstDept on emp.DeptNo equals dept.DeptNo select new { emp.Name, emp.Basic ,emp.DeptNo};

        /* TODO*/

            foreach (var item in emps1)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Basic);

                Console.WriteLine();
                Console.WriteLine();


            }
            Console.ReadLine();
        }

        // query as a function/methods
        static void Main(string[] args)
        {
            AddRecords();


            var emps = from emp in lstEmp join dept in lstDept on emp.DeptNo equals dept.DeptNo select new { emp.Name, emp.Basic, emp.DeptNo };

            // var emps = from emp in lstEmp select emp

            // passing function as a parameter to select
            var emps1 = lstEmp.Select(GetEmployees);

            // using anpnymous methods
            var emps2 = lstEmp.Select(delegate(Employee e)
            {

                return e;
            });
            // using lambda
            var emps3 = lstEmp.Select(emp => emp);


            foreach (var item in emps3)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Basic);

                Console.WriteLine();
                Console.WriteLine();


            }
            Console.ReadLine();
        }
        public static void AddRecords()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "Sales" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vikas",  Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit",Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona",   Basic = 13000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "shweta", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 12000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan",  Basic = 13000, DeptNo = 30, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shradha",Basic = 11000, DeptNo = 40, Gender = "F" });


        }
        public static Employee GetEmployees(Employee e)
        {

            return e;
        }
    }
}

public class Department
{
    public int DeptNo { get; set; }
    public string DeptName { get; set; }

}


public class Employee
{
    public int EmpNo { get; set; }
    public string Name { get; set; }

    public int Basic { get; set; }
    public int DeptNo { get; set; }
    public string Gender { get; set; }


}
/*
 LINQ -> Language INtegreated Query
- it provides comman syntax to get data from all different datasourses like Collections , Database ,Xml and Dataset 
- 
 
 */