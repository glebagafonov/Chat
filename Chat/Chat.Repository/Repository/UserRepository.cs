using System.Collections.Generic;

namespace Chat.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        readonly Dictionary<int, User> _users = new Dictionary<int, User>();
    }
}