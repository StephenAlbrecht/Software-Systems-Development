﻿#pragma checksum "..\..\Cart.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "700C52067F4364855A8347F190F697B4C0FF1540"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoWand;
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


namespace AutoWand {
    
    
    /// <summary>
    /// Cart
    /// </summary>
    public partial class Cart : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CustomerLabel;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel VehicleInfoPanel;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YearEntry;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MakeEntry;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelEntry;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrimEntry;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ServicesListBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CartListView;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ItemTotal;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Tax;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GrandTotal;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoWand;component/cart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Cart.xaml"
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
            this.CustomerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.VehicleInfoPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.YearEntry = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\Cart.xaml"
            this.YearEntry.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MakeEntry = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\Cart.xaml"
            this.MakeEntry.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ModelEntry = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\Cart.xaml"
            this.ModelEntry.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TrimEntry = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\Cart.xaml"
            this.TrimEntry.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 68 "..\..\Cart.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearFieldsCommand);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ServicesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            
            #line 77 "..\..\Cart.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToCart);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CartListView = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            
            #line 86 "..\..\Cart.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveFromCart);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ItemTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.Tax = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.GrandTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            
            #line 109 "..\..\Cart.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToCart);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 110 "..\..\Cart.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveFromCart);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 113 "..\..\Cart.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SubmitCommand);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 114 "..\..\Cart.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelCommand);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

