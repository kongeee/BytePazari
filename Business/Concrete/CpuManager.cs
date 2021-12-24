using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class CpuManager : ICpuService {
        ICpuDal _cpuDal;

        public CpuManager(ICpuDal cpuDal) {
            _cpuDal = cpuDal;
        }

        public Cpu Get(int cpuId) {
            return _cpuDal.Get(c => c.CpuId == cpuId);
        }

        public List<Cpu> GetAll() {
            return _cpuDal.GetAll();
        }
    }
}