using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class GpuManager : IGpuService {
        IGpuDal _gpuDal;

        public GpuManager(IGpuDal gpuDal) {
            _gpuDal = gpuDal;
        }

        public IDataResult<Gpu> Get(int gpuId) {
            return new SuccessDataResult<Gpu>(_gpuDal.Get(a => a.GpuId == gpuId), Messages.Smsg);
        }

        public IDataResult<List<Gpu>> GetAll() {
            return new SuccessDataResult<List<Gpu>>(_gpuDal.GetAll(), Messages.Smsg);
        }
    }
}