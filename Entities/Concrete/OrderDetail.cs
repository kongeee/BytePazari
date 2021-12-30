using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete {
    public class OrderDetail : IEntity {
        [Key]
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
