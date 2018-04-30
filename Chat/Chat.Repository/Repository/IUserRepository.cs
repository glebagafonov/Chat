using System.Collections.Generic;
using Chat.Domain.Domain.Entity;

namespace Chat.Repository.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetSingle(int id);
        //User Add(User toAdd);
        //User Update(User toUpdate);
        void Delete(int id);
    }
}