﻿#pragma checksum "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711D56161C63593FC2E20E2332AD5AB4FCB9F9F4"
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
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.UI.Xaml.Gauges;
using Syncfusion.Windows;
using Syncfusion.Windows.Collections;
using Syncfusion.Windows.ComponentModel;
using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Grid;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.Scroll;
using Syncfusion.Windows.Controls.VirtualTreeView;
using Syncfusion.Windows.Data;
using Syncfusion.Windows.Diagnostics;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Styles;
using Syncfusion.Windows.Tools;
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
using syncfusion.demoscommon.wpf;


namespace syncfusion.gridcontroldemos.wpf {
    
    
    /// <summary>
    /// CurrencyCell
    /// </summary>
    public partial class CurrencyCell : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.Grid.GridControl grid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CurrencySymbol;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GroupNumber;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DecimalNo;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PositivePattern;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.gridcontroldemos.wpf;component/cell%20types/currencycell/currencycell" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
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
            this.grid = ((Syncfusion.Windows.Controls.Grid.GridControl)(target));
            return;
            case 2:
            this.CurrencySymbol = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GroupNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DecimalNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PositivePattern = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 82 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.PositivePatternSelected);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 85 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.PositivePatternSelected);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 88 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.PositivePatternSelected);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 91 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.PositivePatternSelected);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 101 "..\..\..\..\..\Cell Types\CurrencyCell\CurrencyCell.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetAll);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

