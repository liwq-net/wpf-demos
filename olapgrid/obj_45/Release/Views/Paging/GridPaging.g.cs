﻿#pragma checksum "..\..\..\..\Views\Paging\GridPaging.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2A268441CB10FD2AC72A6D1F4E4F09EB1C8272A631D2F89CEFB0F8936E4CEB9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion.Windows.Grid.Olap;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Shared.Olap;
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
using syncfusion.demoscommon.wpf;
using syncfusion.olapgriddemos.wpf;


namespace syncfusion.olapgriddemos.wpf {
    
    
    /// <summary>
    /// GridPaging
    /// </summary>
    public partial class GridPaging : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Views\Paging\GridPaging.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Grid.Olap.OlapGrid olapGrid1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\Paging\GridPaging.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox pagerGroupBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\Paging\GridPaging.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.Olap.OlapPager pagerControl;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\Paging\GridPaging.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbEnable;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.olapgriddemos.wpf;component/views/paging/gridpaging.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Paging\GridPaging.xaml"
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
            this.olapGrid1 = ((Syncfusion.Windows.Grid.Olap.OlapGrid)(target));
            return;
            case 2:
            this.pagerGroupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.pagerControl = ((Syncfusion.Windows.Shared.Olap.OlapPager)(target));
            return;
            case 4:
            this.cbEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

