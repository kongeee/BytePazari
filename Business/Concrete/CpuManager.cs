using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<Cpu> Get(int cpuId) {
            return new SuccessDataResult<Cpu>(_cpuDal.Get(a => a.CpuId == cpuId), Messages.Smsg);
        }

        public IDataResult<List<Cpu>> GetAll() {
            return new SuccessDataResult<List<Cpu>>(_cpuDal.GetAll(), Messages.Smsg);
        }
    }
}