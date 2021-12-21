using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class OrderDetail : IEntity {
        public int DetailId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
