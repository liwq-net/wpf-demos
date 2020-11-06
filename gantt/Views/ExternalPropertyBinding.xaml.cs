#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.ganttdemos.wpf
{
    /// <summary>
    /// Interaction logic for ExternalPropertyBinding.xaml
    /// </summary>
    public partial class ExternalPropertyBinding : DemoControl
    {
        ExternalPropertyBindingViewModel externalPropertyBindingViewModel;
        public ExternalPropertyBinding()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (externalPropertyBindingViewModel == null)
                externalPropertyBindingViewModel = this.DataContext as ExternalPropertyBindingViewModel;
            externalPropertyBindingViewModel.Dispose();
            base.Dispose(disposing);
        }
    }
}
