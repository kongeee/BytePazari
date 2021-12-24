using Business.Abstract;
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

        public Ram Get(int ramId) {
            return _ramDal.Get(r => r.RamId == ramId);
        }

        public List<Ram> GetAll() {
            return _ramDal.GetAll();
        }
    }
}