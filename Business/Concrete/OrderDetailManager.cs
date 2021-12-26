using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<OrderDetail> Get(int orderDetailId) {
            return new SuccessDataResult<OrderDetail>(_orderDetailDal.Get(a => a.DetailId == orderDetailId), Messages.Smsg);
        }

        public IDataResult<List<OrderDetail>> GetAll() {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetAll(), Messages.Smsg);
        }
        public IResult Add(OrderDetail orderDetail) {
            _orderDetailDal.Add(orderDetail);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Update(OrderDetail orderDetail) {
            _orderDetailDal.Update(orderDetail);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Delete(OrderDetail orderDetail) {
            _orderDetailDal.Delete(orderDetail);
            return new SuccessResult(Messages.Smsg);
        }
    }
}