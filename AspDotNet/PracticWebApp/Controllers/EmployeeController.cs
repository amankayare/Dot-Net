using PracticWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticWebApp.Controllers
{
   

    public class EmployeeController : Controller
    {
        private SqlConnection cn = new SqlConnection();
        // GET: Employee
        public ActionResult Index()
        {
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from Employees", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            List<Employee> list = new List<Employee>();

            while (dr.Read())
            {

                list.Add(new Employee { EmpNo = (int)dr["EmpNo"], Name = (string)dr["Name"], Basic = (decimal)dr["Basic"], DeptNo = (int)dr["DeptNo"] });
            }

            cn.Close();

            return View(list);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id = 0)
        {
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from Employees where EmpNo = "+id+"", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            Employee emp = new Employee();

            if (dr.Read())
            {
                emp.Basic = (decimal)dr["Basic"];
                emp.Name = (string)dr["Name"];
                emp.DeptNo = (int)dr["DeptNo"];
                emp.EmpNo = (int)dr["EmpNo"];


            }


            cn.Close();


            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Employee emp = new Employee();

            return View(emp);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "insertEmployee";

                cmd.Parameters.AddWithValue("@Name",emp.Name);
                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);

                cmd.ExecuteNonQuery();

                cn.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from Employees where EmpNo = " + id + "", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            Employee emp = new Employee();

            if (dr.Read())
            {
                emp.Basic = (decimal)dr["Basic"];
                emp.Name = (string)dr["Name"];
                emp.DeptNo = (int)dr["DeptNo"];
                emp.EmpNo = (int)dr["EmpNo"];


            }



            cn.Close();


            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "UpdateEmployee";

                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);

                cmd.ExecuteNonQuery();
                cn.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from Employees where EmpNo = " + id + "", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            Employee emp = new Employee();

            if (dr.Read())
            {
                emp.Basic = (decimal)dr["Basic"];
                emp.Name = (string)dr["Name"];
                emp.DeptNo = (int)dr["DeptNo"];
                emp.EmpNo = (int)dr["EmpNo"];


            }
            cn.Close();


            return View(emp);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
        {
            try
            {
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "deleteEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);

                cmd.ExecuteNonQuery();
                cn.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
