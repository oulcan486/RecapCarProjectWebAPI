using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User entity);
        IResult Update(User entity);
        IResult Delete(User entity);
        IDataResult<User> GetById(int id);
    }
}
