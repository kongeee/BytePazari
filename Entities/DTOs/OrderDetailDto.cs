using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs {
    public class OrderDetailDto:IDto {
        public int OrderId { get; set; }
        public string SellerFullname { get; set; }
        public string BuyerFullName { get; set; }
        public string Address { get; set; }
        public double TotalPrice { get; set; }
        public Product[] Products { get; set; }
    }
}
