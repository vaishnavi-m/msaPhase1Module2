﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myButton.Clicked += async (s, e) =>
            {
                Button button = (Button)s;
                await DisplayAlert("Clicked!",
                    "The button labeled '" + button.Text + "' has been clicked",
                    "OK");
                await Navigation.PushModalAsync(new Grid1());
            };
        
        }

    }
}
