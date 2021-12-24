
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs {
    public class ProductDetailDto:IDto {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string CpuName { get; set; }
        public string GpuName { get; set; }
        public string RamName { get; set; }
        public int HddCapacity { get; set; }
        public int SsdCapacity { get; set; }
        public string Monitor { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }

    }
}
