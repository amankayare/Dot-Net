﻿using System;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtFullName.Text = txtFirstName.Text + txtLastName.Text;
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtFullName.Text = txtFirstName.Text+" "+txtLastName.Text;
            

        }
        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtFullName.Text = txtFirstName + " " + txtLastName.Text;
        }
    }
    
}
