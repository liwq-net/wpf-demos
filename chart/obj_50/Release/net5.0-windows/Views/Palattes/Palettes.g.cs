﻿#pragma checksum "..\..\..\..\..\Views\Palattes\Palettes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FAFBF8B9C586AC65F5A2D20EE2121C0ED3D05B5A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using syncfusion.chartdemos.wpf;
using syncfusion.demoscommon.wpf;


namespace syncfusion.chartdemos.wpf {
    
    
    /// <summary>
    /// Palettes
    /// </summary>
    public partial class Palettes : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox palettecombo;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.SfChart areaChart;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.SfChart barChart;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.ColumnSeries barSeries1;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.ColumnSeries barSeries2;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.SfChart doughnutChart;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.DoughnutSeries doughnutSeries;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.chartdemos.wpf;component/views/palattes/palettes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.palettecombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\..\..\Views\Palattes\Palettes.xaml"
            this.palettecombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.palettecombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.areaChart = ((Syncfusion.UI.Xaml.Charts.SfChart)(target));
            return;
            case 4:
            this.barChart = ((Syncfusion.UI.Xaml.Charts.SfChart)(target));
            return;
            case 5:
            this.barSeries1 = ((Syncfusion.UI.Xaml.Charts.ColumnSeries)(target));
            return;
            case 6:
            this.barSeries2 = ((Syncfusion.UI.Xaml.Charts.ColumnSeries)(target));
            return;
            case 7:
            this.doughnutChart = ((Syncfusion.UI.Xaml.Charts.SfChart)(target));
            return;
            case 8:
            this.doughnutSeries = ((Syncfusion.UI.Xaml.Charts.DoughnutSeries)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

