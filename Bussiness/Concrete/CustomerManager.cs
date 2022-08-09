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
    public class CustomerManager : ICustomerService
    {
        public IResult CustomerAdd(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult CustomerDelete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IResult CustomerUpdate(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetByCompanyName(string CName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
