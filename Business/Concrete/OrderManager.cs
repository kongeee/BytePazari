using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class OrderManager : IOrderService {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal) {
            _orderDal = orderDal;
        }

        public Order Get(int orderId) {
            return _orderDal.Get(o => o.OrderId == orderId);
        }

        public List<Order> GetAll() {
            return _orderDal.GetAll();
        }
    }
}