using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class Gpu : IEntity {
        public int GpuId { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }
}
