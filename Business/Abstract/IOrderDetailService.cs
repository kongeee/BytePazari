using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IOrderDetailService {
        List<OrderDetail> GetAll();
        OrderDetail Get(int orderDetailId);
    }
}
