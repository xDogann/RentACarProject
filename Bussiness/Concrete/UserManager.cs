using Bussiness.Abctract;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        public IResult AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetByCompanyName(string CName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
