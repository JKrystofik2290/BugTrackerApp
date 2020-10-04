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

        public List<UsersClass> displayusers()
        {
            return _dbcontext.users.ToList();
        }
    }
}
