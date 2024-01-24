using LoginPageExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Mac;

namespace LoginPageExercise.Services
{

    public class UsersList
    {
        public List<User> Users { get; private set; }
        public UsersList()
        {
            this.Users = new List<User>();
            FillList();
        }

        private void FillList()
        {
            Users.Add(new User
            {
                userName = "Dan",
                password = "Hagit"
            });

            Users.Add(new User
            {
                userName = "Ori",
                password = "Hadas"
            });

            Users.Add(new User
            {
                userName = "Guy",
                password = "Tali"
            });

            Users.Add(new User
            {
                userName = "Yair",
                password = "Meital"
            });

            Users.Add(new User
            {
                userName = "Yali",
                password = "Liat"
            });

            Users.Add(new User
            {
                userName = "Eitan",
                password = "Einat"
            });

            Users.Add(new User
            {
                userName = "Elad",
                password = "Shely"
            });

            Users.Add(new User
            {
                userName = "Ohad",
                password = "Ariela"
            });

            Users.Add(new User
            {
                userName = "Ran",
                password = "Orit"
            });

            Users.Add(new User
            {
                userName = "Idan",
                password = "Dikla"
            });
        }


    }
        public class UserService
        {
            public UserService()
            {
                users = new UsersList().Users;
            }
            List<User> users;

            public bool IsUserExist(User check)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].userName == check.userName && users[i].password == check.password)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    
}
