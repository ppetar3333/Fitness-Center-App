﻿#pragma checksum "..\..\..\..\..\Windows\Administrator\AdminTrainings\AdminTrainingsOptions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CAACA3EB0EA563EB487CFFA57C0C18374DD7F4A943C9CFCDECECE751C8978496"
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
using fitnessCenterProject.Windows.Administrator.AdminTrainings;


namespace fitnessCenterProject.Windows.Administrator.AdminTrainings {
    
    
    /// <summary>
    /// AdminTrainingsOptions
    /// </summary>
    public partial class AdminTrainingsOptions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Windows\Administrator\AdminTrainings\AdminTrainingsOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid trainingsInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/fitnessCenterProject;component/windows/administrator/admintrainings/admintrainin" +
                    "gsoptions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Administrator\AdminTrainings\AdminTrainingsOptions.xaml"
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
            
            #line 13 "..\..\..\..\..\Windows\Administrator\AdminTrainings\AdminTrainingsOptions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.createTraining);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\..\..\Windows\Administrator\AdminTrainings\AdminTrainingsOptions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteTraining);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\..\..\Windows\Administrator\AdminTrainings\AdminTrainingsOptions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.close);
            
            #line default
            #line hidden
            return;
            case 4:
            this.trainingsInfo = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\..\..\Windows\Administrator\AdminTrainings\AdminTrainingsOptions.xaml"
            this.trainingsInfo.AutoGeneratedColumns += new System.EventHandler(this.changeVisibilityTrainings);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
