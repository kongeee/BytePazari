using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IStorageService {
        List<Storage> GetAll();
        Storage Get(int storageId);
    }
}
