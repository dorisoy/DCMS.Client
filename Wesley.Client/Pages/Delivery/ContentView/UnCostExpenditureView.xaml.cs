﻿using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
namespace DCMS.Client.Pages.Market
{

    public partial class UnCostExpenditureView : ContentView
    {
        public UnCostExpenditureView()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        }
    }
}
