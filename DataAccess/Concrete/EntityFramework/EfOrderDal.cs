using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework {
    public class EfOrderDal : EfEntityRepositoryBase<Order, BytePazariContext>, IOrderDal {
        public OrderDetailDto GetOrderDetail(int orderId) {
            throw new NotImplementedException();
        }

        public List<OrderDetailDto> GetOrderDetails() {
            throw new NotImplementedException();
        }

        public List<OrderDetailDto> GetOrderDetailsByBuyerId(int buyerId) {
            throw new NotImplementedException();
        }

        public List<OrderDetailDto> GetOrderDetailsBySellerId(int sellerId) {
            throw new NotImplementedException();
        }
    }
}
