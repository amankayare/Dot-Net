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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Job_Preference_Window.xaml
    /// </summary>
    public partial class Job_Preference_Window : Window
    {
        public Job_Preference_Window()
        {
            InitializeComponent();
        }

        private void job_window_Loaded(object sender, RoutedEventArgs e)
        {
            lstBox1.Items.Add("Development");
            lstBox1.Items.Add("Testing");
            lstBox1.Items.Add("QA");
            lstBox1.Items.Add("DB Aministrator");

            lstBox2.Items.Add("Business Analyst");
            lstBox2.Items.Add("Data Analyst");
            
            
        }

        private void btnAddToRight_Click(object sender, RoutedEventArgs e)
        {
            if (lstBox1.SelectedItem == null)
            {
                MessageBox.Show("No items selected... Please select the items to move !");
            }
            else
            {
                lstBox2.Items.Add(lstBox1.SelectedItem);
                lstBox1.Items.Remove(lstBox1.SelectedItem);
            }
            
        }

        private void btnAddAllToRight_Click(object sender, RoutedEventArgs e)
        {
            
            for (int i=0 ; i < lstBox1.Items.Count; i++)
            {
                lstBox2.Items.Add(lstBox1.Items[i]);

            }
            for (int i = 0; i < lstBox1.Items.Count; i++)
            {
                lstBox1.Items.RemoveAt(i);

            }



        }
    }
}
