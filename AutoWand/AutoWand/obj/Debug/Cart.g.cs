﻿#pragma checksum "..\..\Cart.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A6895733AA70B787BB0A27F47A0C02CD3DA7900"
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
        
        
        #line 40 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YearEntry;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MakeEntry;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelEntry;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrimEntry;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ServicesListView;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Cart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CartListView;
        
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
            this.YearEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.MakeEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ModelEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TrimEntry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ServicesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            
            #line 55 "..\..\Cart.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToCart);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CartListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            
            #line 64 "..\..\Cart.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveFromCart);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 84 "..\..\Cart.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToCart);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 85 "..\..\Cart.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveFromCart);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

