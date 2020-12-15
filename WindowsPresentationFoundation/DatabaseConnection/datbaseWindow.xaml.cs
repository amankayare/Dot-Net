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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False
           
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";
           
            cn.Open();

            SqlCommand cmd = new SqlCommand();
           
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
         
            //  cmd.CommandText = "insert into Employees values(1,'Vikram',10000,10)";
            cmd.CommandText = "insert into Employees values("+txtEmpNo.Text+",'"+txtName.Text+"',"+txtBasic.Text+","+txtDeptNo.Text+")";
            
            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            cn.Close();
        }

        // using prepared statements
        private void btnSecure_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            //  cmd.CommandText = "insert into Employees values(1,'Vikram',10000,10)";
            cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)"; // This will resolve problemn of SQL Injection and special character
            cmd.Parameters.AddWithValue("@EmpNo",txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);


            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            cn.Close();
        }

        // using stored procedure
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            //  cmd.CommandText = "insert into Employees values(1,'Vikram',10000,10)";
            cmd.CommandText = "InsertEmployee"; // This will resolve problemn of SQL Injection and special character
         
            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);


            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            cn.Close();

        }

        // delete btn
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            //  cmd.CommandText = "insert into Employees values(1,'Vikram',10000,10)";
            cmd.CommandText = "DeleteEmployee"; // This will resolve problemn of SQL Injection and special character

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            /*cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);*/


            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            cn.Close();

        }

        // update btn
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            //  cmd.CommandText = "insert into Employees values(1,'Vikram',10000,10)";
            cmd.CommandText = "UpdateEmployee"; // This will resolve problemn of SQL Injection and special character

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);


            try
            {
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            cn.Close();
        }

        // Transaction 
        private void btnTransaction_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            
            cmd.Transaction = t;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Employees values(1,'Vikram',10000,10)";
          
            SqlCommand cmd2 = new SqlCommand();

            cmd2.Connection = cn;
            cmd2.Transaction = t;
          
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values(100,'new Emp',1234,90)";

           

            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                t.Commit();
                MessageBox.Show(cmd.CommandText);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                t.Rollback();

            }


            cn.Close();
        }

        
        // use execute scalar when query returns single value only , usually with aggregate functions

        private void btnExecuteScalar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;


            cmd.CommandType = CommandType.Text;

            // cmd.CommandText = "select Name from Employees";
            cmd.CommandText = "select count(*) from Employees";

            MessageBox.Show(cmd.ExecuteScalar().ToString());



            cn.Close();
        }
    }
}
