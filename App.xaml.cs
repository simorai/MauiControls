﻿using MauiControls.Pages;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MauiPresentationControls());
            //MainPage = new NavigationPage(new MauiCommandControls());
            MainPage = new NavigationPage(new MauiSetValueControls());
        }
    }
}
