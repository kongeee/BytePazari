using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class OrderDetailManager : IOrderDetailService {
        IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal) {
            _orderDetailDal = orderDetailDal;
        }

        public OrderDetail Get(int orderDetailId) {
            return _orderDetailDal.Get(od => od.DetailId == orderDetailId);
        }

        public List<OrderDetail> GetAll() {
            return _orderDetailDal.GetAll();
        }
    }
}