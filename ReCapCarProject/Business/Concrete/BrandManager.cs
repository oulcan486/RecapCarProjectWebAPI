using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand entity)
        {
            _brandDal.Add(entity);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour==15)
            {
                return new ErrorDataResult<List<Brand>>(Messages.Fail);
            }
           return new SuccesDataResult<List<Brand>> (_brandDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccesDataResult<Brand> (_brandDal.Get(b=>b.Id==id),Messages.GetProductById);
        }

        public IResult Update(Brand entity)
        {
             _brandDal.Update(entity);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
