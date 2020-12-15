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
    /// Interaction logic for Sum_Window.xaml
    /// </summary>
    public partial class Sum_Window : Window
    {
        public Sum_Window()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int temp = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            txtSum.Text = temp.ToString();
        }
    }
}
