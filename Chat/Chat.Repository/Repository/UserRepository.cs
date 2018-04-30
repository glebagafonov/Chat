using System;
using System.Collections.Generic;
using System.Linq;
using Chat.Domain.Domain;
using Chat.Domain.Domain.Entity;
using Chat.Domain.Domain.Enum;
using Chat.Repository.Repository;

namespace Chat.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        readonly Dictionary<int, User> _users = new Dictionary<int, User>();
        readonly System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);

        public UserRepository()
        {
            _users.Add(1, new User() { Id = new Guid("1"), DateTime = date1, Email = "ztv@pdr.ru", Password = "123", State = new EEntityState(), Timestamp = date1, UserInfo = new UserInfo()});
        }

        public List<User> GetAll()
        {
            return _users.Select(x => x.Value).ToList();
        }

        public User GetSingle(int id)
        {
            return _users.FirstOrDefault(x => x.Key == id).Value;
        }
        
        public User Add(User toAdd)
        {

            var newId = !GetAll().Any() ? 1 : GetAll().Max(x => x.Id.);
            toAdd.Id = newId;
            _houses.Add(newId, toAdd);
            return toAdd;
        }

        public HouseEntity Update(HouseEntity toUpdate)
        {
            HouseEntity single = GetSingle(toUpdate.Id);

            if (single == null)
            {
                return null;
            }

            _houses[single.Id] = toUpdate;
            return toUpdate;
        }

        public void Delete(int id)
        {
            _users.Remove(id);
        }
    }
}