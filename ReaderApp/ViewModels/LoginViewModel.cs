using System;
using ReaderApp.Models;
using Xamarin.Forms;

namespace ReaderApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(ExecuteLogin, () => !IsBusy);
        }

        async void ExecuteLogin()
        { 
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
