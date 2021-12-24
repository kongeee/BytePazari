using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class Cpu : IEntity {
        public int CpuId { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }
}
