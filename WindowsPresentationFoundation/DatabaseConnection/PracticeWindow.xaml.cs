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
    /// Interaction logic for PracticeWindow.xaml
    /// </summary>
    public partial class PracticeWindow : Window
    {
        public PracticeWindow()
        {
            InitializeComponent();
        }
        DataSet ds;

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=practiceDb;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "InsertStudent";

            cmd.Parameters.AddWithValue("@Name",txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
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


        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=practiceDb;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from Students";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = cmd;

            ds = new DataSet();

            dataAdapter.Fill(ds, "Stud");

            cmd.CommandText = "select * from Departments";

            dataAdapter.Fill(ds, "Dept");


            dgStudents.ItemsSource = ds.Tables["Stud"].DefaultView;


            /*
            DataColumn[] arrCols = new DataColumn[1];
            arrCols[0] = ds.Tables["Stud"].Columns["StudentId"];
            ds.Tables["Stud"].PrimaryKey = arrCols;
            */

            ds.Relations.Add(ds.Tables["Dept"].Columns["DeptNo"], ds.Tables["Stud"].Columns["DeptNo"]);




            cn.Close();
        }
        private void btnUpdateStudent__Click(object sender, RoutedEventArgs e)
        {

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=practiceDb;Integrated Security=True;Pooling=False";

            cn.Open(); 


            SqlCommand Updatecmd = new SqlCommand(); 
            Updatecmd.Connection = cn;
            Updatecmd.CommandType = CommandType.StoredProcedure;
            Updatecmd.CommandText = "UpdateStudent";

           


            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@Email", SourceColumn = "Email", SourceVersion = DataRowVersion.Current });
            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@Phone", SourceColumn = "Phone", SourceVersion = DataRowVersion.Current });
            Updatecmd.Parameters.Add(new SqlParameter { ParameterName = "@StudentId", SourceColumn = "StudentId", SourceVersion = DataRowVersion.Original });



            SqlCommand Deletecmd = new SqlCommand(); 
            Deletecmd.Connection = cn;
            Deletecmd.CommandType = CommandType.StoredProcedure;
            Deletecmd.CommandText = "DeleteStudent";

            Deletecmd.Parameters.Add(new SqlParameter { ParameterName = "@StudentId", SourceColumn = "StudentId", SourceVersion = DataRowVersion.Original });




            SqlCommand Insertcmd = new SqlCommand();
            Insertcmd.Connection = cn;
            Insertcmd.CommandType = CommandType.StoredProcedure;
            Insertcmd.CommandText = "InsertStudent"; 


            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@Email", SourceColumn = "Email", SourceVersion = DataRowVersion.Current });
            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@Phone", SourceColumn = "Phone", SourceVersion = DataRowVersion.Current });
            //Insertcmd.Parameters.Add(new SqlParameter { ParameterName = "@StudentId", SourceColumn = "StudentId", SourceVersion = DataRowVersion.Original });

            SqlDataAdapter da = new SqlDataAdapter();

            da.UpdateCommand = Updatecmd;
            da.DeleteCommand = Deletecmd;
            da.InsertCommand = Insertcmd;


            da.Update(ds, "Stud");


            cn.Close();


        }

      
    }
}
