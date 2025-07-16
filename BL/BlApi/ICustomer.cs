﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ICustomer
    {
        int Create(BO.Customer item);
        BO.Customer? Read(int id);
        List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null);
        void Update(BO.Customer item);
        void Delete(int id);
        bool IsCustomerExist(int id);
    }
}
