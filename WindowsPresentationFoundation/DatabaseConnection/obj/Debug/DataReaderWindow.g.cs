﻿#pragma checksum "..\..\DataReaderWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1505951F17331B8E262F62C473BC7C6120BE739DD6BE6C10A2C6F280491A5024"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DatabaseConnection;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DatabaseConnection {
    
    
    /// <summary>
    /// DataReaderWindow
    /// </summary>
    public partial class DataReaderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\DataReaderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid btnSelect;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\DataReaderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstBox1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\DataReaderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelect1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DataReaderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReadEmpAndDept;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\DataReaderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeptWiseEmp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DatabaseConnection;component/datareaderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DataReaderWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnSelect = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.lstBox1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnSelect1 = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\DataReaderWindow.xaml"
            this.btnSelect1.Click += new System.Windows.RoutedEventHandler(this.btnSelect1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReadEmpAndDept = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\DataReaderWindow.xaml"
            this.btnReadEmpAndDept.Click += new System.Windows.RoutedEventHandler(this.btnReadEmpAndDept_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDeptWiseEmp = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\DataReaderWindow.xaml"
            this.btnDeptWiseEmp.Click += new System.Windows.RoutedEventHandler(this.btnDeptWiseEmp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

