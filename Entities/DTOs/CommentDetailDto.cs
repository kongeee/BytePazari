using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs {
    public class CommentDetailDto:IDto {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string ProductName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Rating { get; set; }
    }
}
