namespace Work3
{
    public interface IUserService
    {
        void CreateUser(UserService user);
        void DeleteUser(int id);
        void EditUser(User user);
        User[] GetAllUsers();
        User GetUserById(int id);
        bool ValidateUser(User user);
    }
}