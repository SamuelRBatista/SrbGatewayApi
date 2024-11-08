﻿using UserAPI.Model;

namespace UserAPI.Service
{
    public interface IUserService
    {
        public IEnumerable<User> GetUserList();
        public User GetUserById(int id);
        public User AddUser(User product);
        public User UpdateUser(User product);
        public bool DeleteUser(int Id);
    }
}
