using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete {
    public class Comment : IEntity {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Rating { get; set; }
    }
}
