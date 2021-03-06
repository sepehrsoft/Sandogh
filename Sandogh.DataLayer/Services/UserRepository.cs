﻿ using Sandogh.DataLayer.Context;
using Sandogh.DataLayer.Repository;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sandogh.DataLayer.Services
{
    public class UserRepository : GenericRepository<User>, IUserRepository<User>
    {
        private readonly Sandogh_DBEntities _db;
        private readonly DbSet<UserRepository> _dbSet;
        public UserRepository(Sandogh_DBEntities db) : base(db)
        {
            _db = db;
            _dbSet = _db.Set<UserRepository>();
        }

        public IList<UserSimpleView> GetAllUserSimpleDetails()
        {
            return _db.UserSimpleViews.ToList();
        }


        public UserFullView GetUserFullDetailsById(int id)
        {
            return _db.UserFullViews.SingleOrDefault(c => c.UserID == id);
        }


        public UserFullView GetUserWithJobDetailsByID(int id)
        {
            return _db.UserFullViews.Find(id);
        }


        public UserFullView Login(string username, string password)
        {
            return _db.UserFullViews.SingleOrDefault(c => c.UserName.Equals(username) && c.Password.Equals(password));
        }

        IEnumerable<User> IGenericRepository<User>.GetAll()
        {
            return base.Get();
        }

        IEnumerable<UserFullView> IUserRepository<User>.GetAllUserFullDetails()
        {
            return _db.UserFullViews.ToList();
        }
        UserFullView IUserRepository<User>.GetUserFullDetailsByNationalCode(string nationalCode)
        {
            return _db.UserFullViews.FirstOrDefault(c=>c.NationalCode.Equals(nationalCode));
        }
        User IGenericRepository<User>.GetById(object id)
        {
            return _db.Users.Find(id);
        }


    }
}
