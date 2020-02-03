﻿using CFinanc.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CFinanc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
