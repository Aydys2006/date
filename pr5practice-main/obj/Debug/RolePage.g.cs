﻿#pragma checksum "..\..\RolePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0616A5F1C01DAD6BC043DA3288A849520D022FC02B0F00B3221A02375A78F957"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using pr5;


namespace pr5 {
    
    
    /// <summary>
    /// RolePage
    /// </summary>
    public partial class RolePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RoleGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoleBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ADDButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RolePagee;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PeoplePage;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginPage;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\RolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FirstFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/pr5;component/rolepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RolePage.xaml"
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
            this.RoleGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\RolePage.xaml"
            this.RoleGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RoleGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RoleBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DelButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\RolePage.xaml"
            this.DelButton.Click += new System.Windows.RoutedEventHandler(this.DelButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ADDButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\RolePage.xaml"
            this.ADDButton.Click += new System.Windows.RoutedEventHandler(this.ADDButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ChangeButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\RolePage.xaml"
            this.ChangeButton.Click += new System.Windows.RoutedEventHandler(this.ChangeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RolePagee = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\RolePage.xaml"
            this.RolePagee.Click += new System.Windows.RoutedEventHandler(this.RolePagee_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PeoplePage = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\RolePage.xaml"
            this.PeoplePage.Click += new System.Windows.RoutedEventHandler(this.PeoplePage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LoginPage = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\RolePage.xaml"
            this.LoginPage.Click += new System.Windows.RoutedEventHandler(this.LoginPage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FirstFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
