﻿#pragma checksum "MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83D0414D9CA303C59497C95AA1111E7213473443E6B6E90848EFDE3A25ED2C4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UCalc;


namespace UCalc {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Title;
        
        #line default
        #line hidden
        
        
        #line 58 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CostTitle;
        
        #line default
        #line hidden
        
        
        #line 63 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EnergyCostInput;
        
        #line default
        #line hidden
        
        
        #line 66 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MassCostInput;
        
        #line default
        #line hidden
        
        
        #line 69 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BuildTimeCostInput;
        
        #line default
        #line hidden
        
        
        #line 75 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Calculate;
        
        #line default
        #line hidden
        
        
        #line 82 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Clear;
        
        #line default
        #line hidden
        
        
        #line 103 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MulitResult;
        
        #line default
        #line hidden
        
        
        #line 130 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewEMultiInput;
        
        #line default
        #line hidden
        
        
        #line 133 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewMCostInput;
        
        #line default
        #line hidden
        
        
        #line 136 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewBTMultiInput;
        
        #line default
        #line hidden
        
        
        #line 142 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_ReCalculate;
        
        #line default
        #line hidden
        
        
        #line 149 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Clear2;
        
        #line default
        #line hidden
        
        
        #line 170 "MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewCostResult;
        
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
            System.Uri resourceLocater = new System.Uri("/UCalc;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "MainWindow.xaml"
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
            this.Title = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.CostTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.EnergyCostInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MassCostInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BuildTimeCostInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Button_Calculate = ((System.Windows.Controls.Button)(target));
            
            #line 75 "MainWindow.xaml"
            this.Button_Calculate.Click += new System.Windows.RoutedEventHandler(this.Button_Caculate_Mulit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Button_Clear = ((System.Windows.Controls.Button)(target));
            
            #line 82 "MainWindow.xaml"
            this.Button_Clear.Click += new System.Windows.RoutedEventHandler(this.Button_Clear_Mulitplier_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MulitResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.NewEMultiInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.NewMCostInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.NewBTMultiInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Button_ReCalculate = ((System.Windows.Controls.Button)(target));
            
            #line 142 "MainWindow.xaml"
            this.Button_ReCalculate.Click += new System.Windows.RoutedEventHandler(this.Button_Calculate_Cost_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Button_Clear2 = ((System.Windows.Controls.Button)(target));
            
            #line 149 "MainWindow.xaml"
            this.Button_Clear2.Click += new System.Windows.RoutedEventHandler(this.Button_Clear_Cost_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.NewCostResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

