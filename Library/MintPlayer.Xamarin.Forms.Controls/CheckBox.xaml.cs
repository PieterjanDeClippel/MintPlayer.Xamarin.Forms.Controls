﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MintPlayer.Xamarin.Forms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckBox : ContentView
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        //#region IsChecked
        //public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(CheckBox), propertyChanged: (bindable, oldValue, newValue) =>
        //{

        //});

        //public bool IsChecked
        //{
        //    get => (bool)GetValue(IsCheckedProperty);
        //    set => SetValue(IsCheckedProperty, value);
        //}
        //#endregion

        #region Text
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CheckBox), "");
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        #endregion

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    IsChecked = !IsChecked;
        //}
    }
}