﻿#pragma checksum "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C036559051E3015225C69D81314EBAEF526E6141C50415BD692F18AF27CE09E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Abituria;
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
using WpfMath.Controls;


namespace Abituria.pages {
    
    
    /// <summary>
    /// Z18Page
    /// </summary>
    public partial class Z18Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 275 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox1;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox2;
        
        #line default
        #line hidden
        
        
        #line 277 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox3;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox4;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdHint;
        
        #line default
        #line hidden
        
        
        #line 296 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hintField;
        
        #line default
        #line hidden
        
        
        #line 297 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfMath.Controls.FormulaControl hintFormula;
        
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
            System.Uri resourceLocater = new System.Uri("/Abituria;component/pages/finalexams/z/z18page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
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
            this.checkBox1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.checkBox2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.checkBox3 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.checkBox4 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            
            #line 289 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConfirmBtn);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 290 "..\..\..\..\..\pages\finalexams\Z\Z18Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HintBtn);
            
            #line default
            #line hidden
            return;
            case 7:
            this.brdHint = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.hintField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.hintFormula = ((WpfMath.Controls.FormulaControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

