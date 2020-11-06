#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace syncfusion.pivotgriddemos.wpf
{
    using System.Collections;

    public class RowPivotsOnlyViewModel
    {
        private IList data;

        public IList Data
        {
            get
            {
                this.data = this.data ?? DataProvider<BO>.GetData();
                return this.data;
            }
            set { this.data = value; }
        }
    }
}
