using static Work3.UserRepository;
using static Work3.User;
using System;
using System.Collections.Generic;
using static PSP.EmailValidator;
using static PSP.PasswordChecker;
using static PSP.PhoneValidator;

namespace Work3
{
    public class UserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public void CreateUser(User user)
        {
            if (ValidateUser(user))
            {
                List<User> users = new List<User>(_repository.LoadAll());
                users.Add(user);
                _repository.SaveAll(users.ToArray());
                Console.WriteLine("Added user");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public void DeleteUser(int id)
        {
            List<User> users = new List<User>(_repository.LoadAll());
            users.RemoveAll(u => u.UserID == id);
            _repository.SaveAll(users.ToArray());
            Console.WriteLine("removed");
        }

        public void EditUser(User user)
        {
            if (ValidateUser(user))
            {
                List<User> users = new List<User>(_repository.LoadAll());
                var idx = users.FindIndex(u => u.UserID == user.UserID);
                users[idx] = user;
                _repository.SaveAll(users.ToArray());
                Console.WriteLine("edited");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public User[] GetAllUsers()
        {
            return _repository.LoadAll();
        }

        public User GetUserById(int id)
        {
            List<User> users = new List<User>(_repository.LoadAll());
            var idx = users.FindIndex(u => u.UserID == id);
            return users[idx];
        }

        public bool ValidateUser(User user)
        {
            EmailValidator eValid = new EmailValidator();
            PasswordChecker pValid = new PasswordChecker();
            PhoneValidator phValid = new PhoneValidator();
            if (eValid.IsValid(user.Password) &&
                pValid.IsValid(user.Email) &&
                phValid.IsValid(user.PhoneNumber))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Bad user info.");
                return false;
            }
        }
    }
}