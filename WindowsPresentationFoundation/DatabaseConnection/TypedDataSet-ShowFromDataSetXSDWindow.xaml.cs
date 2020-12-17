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
using System.Data;
using System.Data.SqlClient;
using DatabaseConnection.MyDataSetTableAdapters;

namespace DatabaseConnection
{
    /// <summary>
    /// Interaction logic for TypedDataSet_ShowFromDataSetXSDWindow.xaml
    /// </summary>
    /// 


    // Typed data set already contain some tables i.e. we can make data set from ui similar to add project we can add data set and drag and drop  tables from server explorer into data set window it will make dataset automatically 
    // all methods calls , Adaptor creation, command creation and other configuration will be done in advance we just need to use Fill() and Update() method directly
    public partial class TypedDataSet_ShowFromDataSetXSDWindow : Window
    {
        public TypedDataSet_ShowFromDataSetXSDWindow()
        {
            InitializeComponent();
        }

        MyDataSet ds;
        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            ds = new MyDataSet();// creating object of our  own already created data set

            DepartmentsTableAdapter daDepts = new DepartmentsTableAdapter();
            daDepts.Fill(ds.Departments);

            EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
            daEmps.Fill(ds.Employees);


            dgEmps.ItemsSource = ds.Employees.DefaultView;

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
            daEmps.Update(ds.Employees);
        }
    }
}
