using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class CommentManager : ICommentService {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal) {
            _commentDal = commentDal;
        }

        public Comment Get(int commentId) {
            return _commentDal.Get(c => c.CommentId== commentId);
        }

        public List<Comment> GetAll() {
            return _commentDal.GetAll();
        }
    }
}