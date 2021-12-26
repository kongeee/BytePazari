using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework {
    public class EfCommentDal : EfEntityRepositoryBase<Comment, BytePazariContext>, ICommentDal {
        public List<CommentDetailDto> GetCommentDetails() {
            throw new NotImplementedException();
        }

        public List<CommentDetailDto> GetCommentDetailsbyId(int id) {
            throw new NotImplementedException();
        }
    }
}
