using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IGpuService {
        IDataResult<List<Gpu>> GetAll();
        IDataResult<Gpu> Get(int gpuId);
    }
}
