﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IOrderDetailService {
        IDataResult<List<OrderDetail>> GetAll();
        IDataResult<OrderDetail> Get(int orderDetailId);
        IResult Add(OrderDetail orderDetail);
        IResult Update(OrderDetail orderDetail);
        IResult Delete(OrderDetail orderDetail);

    }
}
