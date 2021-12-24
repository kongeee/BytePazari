using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class Address:IEntity {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string AddressInfo { get; set; }
    }
}
