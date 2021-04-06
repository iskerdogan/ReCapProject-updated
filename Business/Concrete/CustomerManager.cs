﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            if (customer.UserId != 0)
            {
                _customerDal.Add(customer);
                return new SuccessResult(Messages.CustomerAdded);
            }
            return new ErrorResult(Messages.Error);
        }

        public IResult Delete(Customer customer)
        {
            if (customer.Id != 0)
            {
                _customerDal.Delete(customer);
                return new SuccessResult(Messages.CustomerDeleted);
            }
            return new ErrorResult(Messages.Error);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
