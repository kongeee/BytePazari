using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete {
    public class ProductImage:IEntity {
        [Key]
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public string Path { get; set; }
        public DateTime Date { get; set; }
    }
}
