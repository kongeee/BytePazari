using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class RamManager : IRamService {
        IRamDal _ramDal;

        public RamManager(IRamDal ramDal) {
            _ramDal = ramDal;
        }

        public IDataResult<Ram> Get(int ramId) {
            return new SuccessDataResult<Ram>(_ramDal.Get(a => a.RamId == ramId), Messages.Smsg);
        }

        public IDataResult<List<Ram>> GetAll() {
            return new SuccessDataResult<List<Ram>>(_ramDal.GetAll(), Messages.Smsg);
        }
    }
}