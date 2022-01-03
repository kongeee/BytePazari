using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework {
    public class EfCommentDal : EfEntityRepositoryBase<Comment, BytePazariContext>, ICommentDal {
        public List<CommentDetailDto> GetCommentDetails() {
            using(BytePazariContext context = new BytePazariContext()) {
                var result = from c in context.Comments
                             join u in context.Users on c.UserId equals u.UserId
                             join p in context.Products on c.ProductId equals p.ProductId
                             select new CommentDetailDto {
                                 CommentId = c.CommentId,
                                 Content = c.Content,
                                 ProductName = p.Name,
                                 Rating = c.Rating,
                                 Title = c.Title,
                                 UserName = u.Name,
                                 UserSurname = u.Surname
                             };
                return result.ToList();
            }
        }

        public List<CommentDetailDto> GetCommentDetailsbyId(int id) {
            using (BytePazariContext context = new BytePazariContext()) {
                var result = from c in context.Comments
                             join u in context.Users on c.UserId equals u.UserId
                             join p in context.Products on c.ProductId equals p.ProductId
                             where c.ProductId == p.ProductId
                             select new CommentDetailDto {
                                 CommentId = c.CommentId,
                                 Content = c.Content,
                                 ProductName = p.Name,
                                 Rating = c.Rating,
                                 Title = c.Title,
                                 UserName = u.Name,
                                 UserSurname = u.Surname
                             };
                return result.ToList();
            }
        }

       
    }
}
