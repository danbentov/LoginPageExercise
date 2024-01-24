using LoginPageExercise.Models;
using LoginPageExercise.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageExercise.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion



        private string username;
        public string Username
        {
            get { return this.username; }
            set
            {
                this.username = value;
                OnPropertyChanged();
            }
        }

        private string password;
        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
                OnPropertyChanged();
            }
        }

        private string message;
        public string Message
        {
            get { return this.message; }
            set
            {
                this.message = value;
                OnPropertyChanged();
            }
        }

        

        private Color color;
        public Color Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
                OnPropertyChanged();
            }
        }

        public LoginPageViewModel()
        {
            CancelCommand = new Command(Cancel);
            CheckUserCommand = new Command(CheckUser);
        }

        public Command CancelCommand { get; set; }

        public Command CheckUserCommand { get; set; }

        private void CheckUser()
        {
            UserService service = new UserService();
            User u = new User
            {
                userName = username,
                password = password
            };

            if (service.IsUserExist(u) == true)
            {
                Message = "Login Succeeded !";
                Color = Colors.Green;
            }
            else
            {
                Message = "Login Failed !";
                Color = Colors.Red;
            }

        }

        private void Cancel()
        {
            Username = "";
            Password = "";
            Message = "";
            Color = Colors.Black;
        }
    }
}
