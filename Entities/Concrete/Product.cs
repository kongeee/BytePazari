using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class Product : IEntity {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public int CpuId { get; set; }
        public int GpuId { get; set; }
        public int RamId { get; set; }
        public int StorageId { get; set; }
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Monitor { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }

    }
}
