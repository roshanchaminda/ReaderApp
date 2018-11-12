using System;
using System.Collections.Generic;
using ReaderApp.ViewModels;
using Xamarin.Forms;

namespace ReaderApp.Views
{
    public partial class LoginPage : ContentPage
    {
        LoginViewModel loginViewModel;

        public LoginPage()
        {
            InitializeComponent();

            BindingContext = loginViewModel = new LoginViewModel();
        }
    }
}
