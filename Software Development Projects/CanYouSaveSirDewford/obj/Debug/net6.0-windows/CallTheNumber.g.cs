﻿#pragma checksum "..\..\..\CallTheNumber.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9D366DE32F16CC2983A66EFEAA510440FC8B98F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CanYouSaveSirDewford;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CanYouSaveSirDewford {
    
    
    /// <summary>
    /// CallTheNumber
    /// </summary>
    public partial class CallTheNumber : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\CallTheNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CallTheNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choice1_btn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CallTheNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choice2_btn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CallTheNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choice3_btn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CallTheNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choice4_btn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CallTheNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CallTheNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label callNumber_txt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CanYouSaveSirDewford;component/callthenumber.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CallTheNumber.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.choice1_btn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\CallTheNumber.xaml"
            this.choice1_btn.Click += new System.Windows.RoutedEventHandler(this.choice1_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.choice2_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\CallTheNumber.xaml"
            this.choice2_btn.Click += new System.Windows.RoutedEventHandler(this.choice2_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.choice3_btn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\CallTheNumber.xaml"
            this.choice3_btn.Click += new System.Windows.RoutedEventHandler(this.choice3_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.choice4_btn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\CallTheNumber.xaml"
            this.choice4_btn.Click += new System.Windows.RoutedEventHandler(this.choice4_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.callNumber_txt = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

