﻿#pragma checksum "..\..\home.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "82DDC5F6F464111BA28156202E52771E0C7FC2D49D009DCBB799E1B839F436C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Calculator;
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


namespace Calculator {
    
    
    /// <summary>
    /// home
    /// </summary>
    public partial class home : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label title;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label result;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label calculation;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_number1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label and;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_number2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_Operation;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalculate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label history;
        
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
            System.Uri resourceLocater = new System.Uri("/Calculator;component/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\home.xaml"
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
            this.title = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.result = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.calculation = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textBox_number1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\home.xaml"
            this.textBox_number1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_zahl1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.and = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.textBox_number2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\home.xaml"
            this.textBox_number2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_zahl2_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.comboBox_Operation = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\home.xaml"
            this.comboBox_Operation.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_operation_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCalculate = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\home.xaml"
            this.btnCalculate.Click += new System.Windows.RoutedEventHandler(this.calculate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.history = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
