using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IDataResult<Car> GetById(int id) {
            return new SuccesDataResult<Car>( _carDal.Get(c=>c.Id==id));
        }
        public IResult Add(Car entity)
        {
            if (entity.Description.Length > 2 && entity.DailyPrice > 0)
            {
                _carDal.Add(entity);
                return new SuccessResult(Messages.ProductAdded);
                
            }
            else
            {
                Console.WriteLine("Eklenemedi");
            }
            return Messages.ProductLoad;
           
        }

       public IResult Update(Car entity) {
            _carDal.Update(entity);
            return new SuccessResult(Messages.ProductUpdated);
                
        }
        public IResult Delete(Car entity) {
            _carDal.Delete(entity);
            return new SuccessResult(Messages.ProductDeleted);
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.GetCarfail);
            }
            return new SuccesDataResult<List<Car>>( _carDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>> (_carDal.GetCarDetail());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccesDataResult<List<Car>> (_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccesDataResult<List<Car>>( _carDal.GetAll(c => c.ColorId == id));
        }
    }
}
