using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Data;

namespace BugTracker.Services
{
    public class UserService
    {
        protected readonly AppDBContext _dbcontext;

        public UserService(AppDBContext _db)
        {
            _dbcontext = _db;
        }

        public List<UsersClass> GetAllUsers()
        {
            return _dbcontext.users.ToList();
        }

        public bool AddUser(UsersClass newuser)
        {
            _dbcontext.users.Add(newuser);
            _dbcontext.SaveChanges();
            return true;
        }
        public UsersClass EditUser(int user_id)
        {
            UsersClass uc = new UsersClass();
            return _dbcontext.users.FirstOrDefault(u => u.id == user_id);
        }

        public bool UpdateUser(UsersClass user_update)
        {
            var Update = _dbcontext.users.FirstOrDefault(u => u.id == user_update.id);
            if (Update != null)
            {
                Update.id = user_update.id;
                Update.name = user_update.name;
                Update.password = user_update.password;
                Update.type = user_update.type;
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteUser(UsersClass user_delete)
        {
            var Delete = _dbcontext.users.FirstOrDefault(u => u.id == user_delete.id);
            if (Delete != null)
            {
                _dbcontext.Remove(Delete);
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
