#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.SfSkinManager;
using System;
using System.ComponentModel;

namespace syncfusion.layoutdemos.wpf
{
    /// <summary>
    /// Interaction logic for ChromelessWindowDemosView.xaml
    /// </summary>
    public partial class GettingStarted
    {
        public GettingStarted()
        {
            InitializeComponent();
        }

        public GettingStarted(string themename)
        {
            SfSkinManager.SetTheme(this, new Theme() { ThemeName = themename });
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Release all managed resources
            if (this.cornerRadiusSlider != null)
            {
                this.cornerRadiusSlider = null;       
            }

            if(this.resizeThicknessSlider != null)
            {
                this.resizeThicknessSlider = null;
            }

            if (this.titleBarHeight != null)
            {
                this.titleBarHeight = null;
            }

            if (this.opacityChanger != null)
            {
                this.opacityChanger = null;
            }
            base.OnClosing(e);
        }
    }
}
