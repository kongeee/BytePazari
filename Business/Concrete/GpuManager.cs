using Business.Abstract;
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

        public Gpu Get(int gpuId) {
            return _gpuDal.Get(g => g.GpuId == gpuId);
        }

        public List<Gpu> GetAll() {
            return _gpuDal.GetAll();
        }
    }
}