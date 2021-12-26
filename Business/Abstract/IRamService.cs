using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IRamService {
        IDataResult<List<Ram>> GetAll();
        IDataResult<Ram> Get(int ramId);
    }
}
