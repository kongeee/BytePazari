using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<Order> Get(int orderId) {
            return new SuccessDataResult<Order>(_orderDal.Get(a => a.OrderId == orderId), Messages.Smsg);
        }

        public IDataResult<List<Order>> GetAll() {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.Smsg);
        }

        public IResult Add(Order order) {
            _orderDal.Add(order);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Update(Order order) {
            _orderDal.Update(order);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Delete(Order order) {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.Smsg);
        }
    }
}