using System;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
	public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int id);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}

