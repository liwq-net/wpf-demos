﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using Syncfusion.Windows.Controls.Gantt.Chart;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace ResourceView
{
    class GanttNodeCustomizationBehavior:Behavior<Border>
    {
        public static Random r = new Random();
        public static string[] nodeColors = new string[] { "#FFFF0094", "#FFA500FF", "#FF00AAAD", "#FF8CBE21", "#FFA55100", "#FFE771BD", "#FFF79608", "#FF18A2E7", "#FFE71400", "#FF319A31" };

        /// <summary>
        /// Called when [attached].
        /// </summary>
        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += new RoutedEventHandler(AssociatedObject_Loaded);
        }

        /// <summary>
        /// Handles the Loaded event of the AssociatedObject control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e)
        {
            Border node = sender as Border;
            node.Background = (Brush)new BrushConverter().ConvertFromString(nodeColors[r.Next(0,9)]);
            node.BorderBrush = node.Background;
        }

        /// <summary>
        /// Called when [detaching].
        /// </summary>
        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= new RoutedEventHandler(AssociatedObject_Loaded);
        }
    }
}