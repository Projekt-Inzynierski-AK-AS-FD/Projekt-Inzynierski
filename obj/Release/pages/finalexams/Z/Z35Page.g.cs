﻿#pragma checksum "..\..\..\..\..\pages\finalexams\Z\Z35Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B851806150125A7B370A449AAF4C161A1C1449B4A9936291C43358B2365696AF"
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
    /// Z35Page
    /// </summary>
    public partial class Z35Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 282 "..\..\..\..\..\pages\finalexams\Z\Z35Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdHint;
        
        #line default
        #line hidden
        
        
        #line 285 "..\..\..\..\..\pages\finalexams\Z\Z35Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hintField;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\..\..\..\pages\finalexams\Z\Z35Page.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Abituria;component/pages/finalexams/z/z35page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\pages\finalexams\Z\Z35Page.xaml"
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
            
            #line 278 "..\..\..\..\..\pages\finalexams\Z\Z35Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConfirmBtn);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 279 "..\..\..\..\..\pages\finalexams\Z\Z35Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HintBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            this.brdHint = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.hintField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.hintFormula = ((WpfMath.Controls.FormulaControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

