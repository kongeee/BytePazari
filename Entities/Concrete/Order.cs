using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class Order : IEntity {
        public int OrderId { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int AddressId { get; set; }
        public double TotalPrice { get; set; }
    }
}
