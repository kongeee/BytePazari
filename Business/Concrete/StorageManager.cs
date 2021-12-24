using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class StorageManager : IStorageService {
        IStorageDal _storageDal;

        public StorageManager(IStorageDal storageDal) {
            _storageDal = storageDal;
        }

        public Storage Get(int storageId) {
            return _storageDal.Get(s => s.StorageId == storageId);
        }

        public List<Storage> GetAll() {
            return _storageDal.GetAll();
        }
    }
}