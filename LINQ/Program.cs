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


            foreach (var item in emps)// var is taken but we can take as string also
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
           // we are getting two columns i.e.  string , decimal therefore we need new class which contains these two properties so we needed an anonymous class 
           // which is written using new keyword
           // its is returning IEnumerable<Anonymous> type

            foreach (var item in emps)// here var is compulsary to take as the emps is of  IEnumerable<Anonymous>  type
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
            /*  Clause comes after the collection*/


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

            var empsX = from emp in lstEmp where (emp.Basic > 10000 && emp.Basic < 13000) orderby emp.Name ascending select emp;
            // combination of where and order clause with each other
            
            var empsY = from emp in lstEmp  orderby emp.Name ascending where (emp.Basic > 10000 && emp.Basic < 13000)  select emp;
            // orderby can come before where cluase and vise versa both are valid

            var empsZ = from emp in lstEmp where emp.Name.StartsWith("Vi") select emp;
            // like clause
            var empsW = from emp in lstEmp where emp.Name.EndsWith("Vi") select emp;
            // like clause

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
        static void Main(string[] args)
        {
            AddRecords();

            // SYNTAX: from obj1 in Collection1 join obj2 in Collection2 on obj1.property equals obj2.Property select Something

            //   var emps1 = from emp in lstEmp join dept in lstDept on emp.DeptNo equals dept.DeptNo select new { emp.Name, emp.Basic ,emp.DeptNo};
            
            var emps1 = from emp in lstEmp join dept in lstDept on emp.DeptNo equals dept.DeptNo select new { emp.Name, emp.Basic, dept.DeptName };


            foreach (var item in emps1)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Basic);
                Console.WriteLine(item.DeptName);

                Console.WriteLine();
                Console.WriteLine();


            }
            Console.ReadLine();
        }

        // query as a function/methods
        static void Main6(string[] args)
        {
            AddRecords();


            var emps = from emp in lstEmp join dept in lstDept on emp.DeptNo equals dept.DeptNo select new { emp.Name, emp.Basic, emp.DeptNo };

            // var emps = from emp in lstEmp select emp

            // passing function as a parameter to select
            var emps1 = lstEmp.Select(GetEmployees);

            // using anonymous methods
            var emps2 = lstEmp.Select(delegate(Employee e)
            {

                return e;
            });
            // using lambda
            var emps3 = lstEmp.Select(emp => emp); // select Method

            var emps4 = lstEmp.Where(emp => emp.Basic > 12000); // select with where clause
            // internally above statment becomes lstEmp.Where(emp => emp.Basic > 12000).Select(emp=>emp) 
            // so for where clause select method should be implemented
            
            var emps5 = lstEmp.Where(emp => emp.Basic > 12000).Select(emp => emp.Name);
            // same as above but we are selecting only Name column not whole object
            
            var emps6 = lstEmp.Where(emp => emp.Basic > 12000).Select(emp => new { emp.Name, emp.DeptNo });
            // same as above but we are selecting only Name and DeptNo column not whole object


            var emps7a = lstEmp.Where(emp => emp.Basic > 12000).Select(emp => emp);
            var emps7b = lstEmp.Select(emp => emp).Where(emp => emp.Basic > 12000);
            // both above statements returns same result event we write 'Where()' first and Select() method second and vice versa i.e. they both are equivalent
            // This concept is only apply when we are getting whole object at once and not valid if not getting whole object

            var emps5a = lstEmp.Where(emp => emp.Basic > 11000).Select(emp => emp.Name);// here whole object is not selected but name only 
            //var emps5b = lstEmp.Select(emp => emp.Name).Where(emp => emp.Basic > 11000);// therefore we cant change the order of where and select 

            var emps8 = lstEmp.OrderBy(emp => emp.Name);

            var emps9 = lstEmp.OrderBy(emp => emp.Name).Select(emp => new { emp.Name, emp.DeptNo }); // can use select with orderby for getting specific columns

            // order by with where 
            var emps10 = lstEmp.OrderBy(emp => emp.Name).Where(emp => emp.Basic > 12000);

            // order by with  desc
            var emps11 = lstEmp.OrderBy(emp => emp.Name).OrderByDescending(emp => emp.Name);

            // order by with where and desc
            var emps12 = lstEmp.OrderBy(emp => emp.Name).Where(emp => emp.Basic > 12000).OrderByDescending(emp => emp.Name);



            //Join        collection1 collection2       col-collection1  col-collection1  Select columns
            var emps13a = lstEmp.Join(lstDept , emp => emp.DeptNo , dept => dept.DeptNo,(emp,dept)=>emp );//select whole object of emp
            var emps13b = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept);//select whole object of dept
            var emps13c = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => emp.Basic);// select Basic of emp 
            var emps13d = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => dept.DeptName);// select DeptName of emp 
            var emps14d = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp.Name, dept.DeptName });// select DeptName of dept and Name of emp 


            // selection two columns with join
            var emps13e = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { dept.DeptName, emp.Basic });

            // Deffered Execution
            var emps14 = from emp in lstEmp select emp;
            /* - In deffered execution ,execution take place only when we use that query 
               - excution not take place at line 224 ->  var emps14 = from emp in lstEmp select emp;
               - execution take place at line no 235 -> foreach (var item in emps14)  { Console.WriteLine(item.Basic); }
               - by default execution is differed execution , to make it immediate use .ToList()
             */
            // immediate execution
            // emps = emps.ToList(); // this will execute query immediaty here


            lstEmp.RemoveAt(0); // if used deffered execution then we will not get the deleted Employee(latest list) otherwise will get old employee list
            foreach (var item in emps14)
            {
                Console.WriteLine(item.Name);

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