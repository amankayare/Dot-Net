using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection
{
    /// <summary>
    /// Interaction logic for DataReaderWindow.xaml
    /// </summary>
    public partial class DataReaderWindow : Window
    {
        public DataReaderWindow()
        {
            InitializeComponent();
        }

        private void btnSelect1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;


            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from Employees";

            SqlDataReader dr = cmd.ExecuteReader();



            /* 
             * 
               
              2  shewta 123.5 20
              3  aman   123.3 30
              4  arpit  789.3 20
              5  pepe   564.3 30
            -> 
            null(EOF)

            dr.Read() ---> True/False return if reader could read the record
            dr[0]
            dr["EmpNo"]


            */

            while (dr.Read())
            {
                lstBox1.Items.Add(dr["Name"]);
                // lstBox1.Items.Add(dr[1]);
                // dr["Name"] = "Aman"; cant change value as DataReader is Read Only

            }
            dr.Close(); // closing is important as DataReaders locks the connection


            cn.Close();
        }

        private void btnReadEmpAndDept_Click(object sender, RoutedEventArgs e)
        {
            
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;


            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from Employees; select * from Departments";

            SqlDataReader dr = cmd.ExecuteReader();




            while (dr.Read())
            {
                lstBox1.Items.Add(dr["Name"]);
                

            }




            dr.NextResult(); // used to read data from 2 tables

            while (dr.Read())
            {
                lstBox1.Items.Add(dr["DeptName"]);


            }




            dr.Close(); // closing is important as DataReaders locks the connection


            cn.Close();

        }

        private void btnDeptWiseEmp_Click(object sender, RoutedEventArgs e)
        {


            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";// adding MultipleActiveResultSets is nessary whaen 2 Darareaders are in use
            cn.Open();
           
            SqlCommand cmdEmp = new SqlCommand();
            cmdEmp.Connection = cn;
            cmdEmp.CommandType = CommandType.Text;
            

            SqlCommand cmdDept = new SqlCommand();
            cmdDept.Connection = cn;
            cmdDept.CommandType = CommandType.Text;
            cmdDept.CommandText = "select * from Departments";


            SqlDataReader Deptdr = cmdDept.ExecuteReader();


            while (Deptdr.Read())
            {
                lstBox1.Items.Add(Deptdr["DeptName"]);
                cmdEmp.CommandText = "select * from Employees where DeptNo ="+Deptdr["DeptNo"];
                SqlDataReader Empdr = cmdEmp.ExecuteReader();

                while (Empdr.Read())
                {
                    lstBox1.Items.Add(" ->  "+Empdr["Name"]);
                }
                Empdr.Close();

            }
            Deptdr.Close();
            cn.Close();
        }

        private void Test()
        {
            SqlDataReader dr = GetDataReader();
            while (dr.Read())
            {
                lstBox1.Items.Add(dr["Name"]);
                // lstBox1.Items.Add(dr[1]);
                // dr["Name"] = "Aman"; cant change value as DataReader is Read Only

            }
            dr.Close(); // closing is important as DataReaders locks the connection
            // cn.Close(); // No need to close connection as we are using CommandBehavior.CloseConnection in GetDataReader()



        }
        private SqlDataReader GetDataReader()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // by adding Command Behaviour it will close all underlying DataReaders connections i.e  connection refernce of this returned DataReader  
            return dr;
        }
    }
}
