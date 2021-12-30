using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class CommentManager : ICommentService {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal) {
            _commentDal = commentDal;
        }

        public IDataResult<Comment> Get(int commentId) {
            return new SuccessDataResult<Comment>(_commentDal.Get(a => a.CommentId == commentId), Messages.Smsg);
        }

        public IDataResult<List<Comment>> GetAll() {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(), Messages.Smsg);
        }

        public IResult Add(Comment comment) {
            _commentDal.Add(comment);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Update(Comment comment) {
            _commentDal.Update(comment);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Delete(Comment comment) {
            _commentDal.Delete(comment);
            return new SuccessResult(Messages.Smsg);
        }

        public IDataResult<List<CommentDetailDto>> GetCommentDetails() {
            return new SuccessDataResult<List<CommentDetailDto>>(_commentDal.GetCommentDetails(), Messages.Smsg);
        }

        public IDataResult<List<CommentDetailDto>> GetCommentsByProductId(int productId) {
            return new SuccessDataResult<List<CommentDetailDto>>(_commentDal.GetCommentDetailsbyId(productId), Messages.Smsg);
        }
    }
}