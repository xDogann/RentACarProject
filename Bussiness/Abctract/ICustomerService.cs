using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abctract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int id);
        IDataResult<Customer> GetByCompanyName(string CName);

        IResult CustomerAdd(Customer customer);
        IResult CustomerDelete(Customer customer);
        IResult CustomerUpdate(Customer customer);

    }
}
