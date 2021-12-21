using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class Storage : IEntity {
        public int StorageId { get; set; }
        public int HddCapacity { get; set; }
        public int SsdCapacity { get; set; }
    }
}
