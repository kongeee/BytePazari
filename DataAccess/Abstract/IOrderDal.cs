using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract {
    public interface IOrderDal:IEntityRepository<Order> {
        List<OrderDetailDto> GetOrderDetails();
        List<OrderDetailDto> GetOrderDetailsBySellerId(int sellerId);
        List<OrderDetailDto> GetOrderDetailsByBuyerId(int buyerId);
        OrderDetailDto GetOrderDetail(int orderId);

    }
}
