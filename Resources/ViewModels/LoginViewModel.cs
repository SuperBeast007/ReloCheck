using System;
using System.ComponentModel;
using System.Windows.Input;
using ReloCheck.Models;

namespace ReloCheck.Resources.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        private LoginRequestModel myloginRequestModel = new LoginRequestModel();
        public LoginRequestModel MyloginRequestModel
        {
            get { return myloginRequestModel; }
            set { myloginRequestModel = value;

                OnPropertyChanged(nameof(MyloginRequestModel));
            }
        }

        public ICommand LoginCommand { get; }


        public LoginViewModel()
        {
            LoginCommand = new Command(PerformLoginOperation);


        }

        private async void PerformLoginOperation(object obj)
        {
            //Perform API Operation/ DB Operation 
            // string Username = "z";
            // string Password = "z";
            //var data = MyloginRequestModel;

            await Shell.Current.GoToAsync(state: "//MainPage");
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
