﻿#pragma checksum "..\..\..\Views\ModuleInput.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2595C2BD428541BB4801B5F36723E5F5D38AB669B82827E99772378BC83E0513"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views;
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


namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views {
    
    
    /// <summary>
    /// ModuleInput
    /// </summary>
    public partial class ModuleInput : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label welcomeText;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox moduleBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberOfCreditsBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox classHoursPerWeekBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox creditsBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox moduleCodeBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox moduleListBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\ModuleInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ST10079389_Kaushil_Dajee_PROG6212_Part_1;component/views/moduleinput.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ModuleInput.xaml"
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
            this.welcomeText = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.moduleBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.numberOfCreditsBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.classHoursPerWeekBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.creditsBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.moduleCodeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.moduleListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\ModuleInput.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.saveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

