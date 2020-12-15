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
    /// Interaction logic for DataSetUsingDataAdaptorWindow.xaml
    /// </summary>
    public partial class DataSetUsingDataAdaptorWindow : Window
    {
        public DataSetUsingDataAdaptorWindow()
        {
            InitializeComponent();
        }



        DataSet ds;

        private void btnFillData_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open(); // Open the connection explicitly is optional Fill() and Update() will open it itself if connection is not open otherwise it uses available open connection.

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataAdapter da = new SqlDataAdapter(); // DataAdopter


            da.SelectCommand = cmd; // our select command , according to this command datatable is created into dataset
            
            ds = new DataSet(); // creating dataset
            //da.Fill(ds);// table is created with default name into dataset
            da.Fill(ds, "Emps"); // with table name to uniquely identify

            cmd.CommandText = "select * from Departments";
            da.Fill(ds, "depttbl");// Another DataTable (Department is added) into Datasets

            //show the created data table inside the grid
            // dgEmps.ItemsSource = ds.Tables[0].DefaultView;
            dgEmps.ItemsSource = ds.Tables["Emps"].DefaultView;


            // validation over datatable
            // primary key validation
            DataColumn[] arrCols = new DataColumn[1];
            arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];// setting column name from data table to the array
            ds.Tables["Emps"].PrimaryKey = arrCols;


            //foriegn key validation  
            ds.Relations.Add(ds.Tables["depttbl"].Columns["DeptNo"],ds.Tables["Emps"].Columns["DeptNo"]);//para 1 -> parent table colmn , para2 -> child table column 


            // Column level Constraints
            // ds.Tables["depttbl"].Columns["DeptName"].Unique = true ;
            
            
            //dr.Close(); // closing is important as DataReaders locks the connection


            cn.Close();



        }

        private void btnUpdateData_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            // Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open(); // Open the collection explicitly is optional Fill() and Update() will open it itself if connection is not open otherwise it uses available open connection.

         
            //update command
            SqlCommand Updatecmd = new SqlCommand(); // 1st command
            Updatecmd.Connection = cn;
            Updatecmd.CommandType = CommandType.Text;
            Updatecmd.CommandText = "update Employees set Name = @Name , Basic=@Basic, DeptNo=@DeptNo where EmpNo=@EmpNo";

            //Updatecmd.Parameters.AddWithValue("@Name",txtName.Text);
            /* 
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@Name";
            p.SourceColumn = "Name";
            p.SourceVersion = DataRowVersion.Current;*/



            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });// primary key and where clause column should be original 


            // delete command
            SqlCommand Deletecmd = new SqlCommand(); // 2nd command
            Deletecmd.Connection = cn;
            Deletecmd.CommandType = CommandType.Text;
            Deletecmd.CommandText = "delete from Employees where EmpNo=@EmpNo";

            Deletecmd.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });




            // Insert command 
            SqlCommand Insertcmd = new SqlCommand(); // 2nd command
            Insertcmd.Connection = cn;
            Insertcmd.CommandType = CommandType.StoredProcedure;
            Insertcmd.CommandText = "InsertEmployee"; // using stored procedure

            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });

            SqlDataAdapter da = new SqlDataAdapter();

            da.UpdateCommand = Updatecmd;
            da.DeleteCommand = Deletecmd;
            da.InsertCommand = Insertcmd;


            da.Update(ds,"Emps");


            cn.Close();





















            /* 
             
            Table Data Goes here ---- Todo
              
              
             
             
             U - Unchanged
             M - Modified
             A - Added
             D- Delete


            da.UpdateCommand = cmdUpdate
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete


            da.Update(ds,"TableName")

            Original Value -> Old value
            Current Value -> Latest value



            DataAdaptor --> will identify the Row State of all rows and accordingly execute respective command(update or delete or insert)
            */
        }
    }
}
