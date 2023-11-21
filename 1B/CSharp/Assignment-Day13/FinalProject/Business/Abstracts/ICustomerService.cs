using System;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface ICustomerService
	{
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(string id);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}

