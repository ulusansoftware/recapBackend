﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int id);
        List<OperationClaim> GetClaims(User user);
        IResult TransactionalOperation(User user);

        User GetByMail(string email);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
