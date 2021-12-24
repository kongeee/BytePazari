using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IRamService {
        List<Ram> GetAll();
        Ram Get(int ramId);
    }
}
