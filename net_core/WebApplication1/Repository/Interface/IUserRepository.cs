public interface IUserRepository
    {
        List<UserModel> GetUsers();
        UserModel GetUserById(int id);
        bool RemoveUserById(int id);
        bool UpdateUser(int id, string name);
        bool InsertUser(UserModel user);
    }
