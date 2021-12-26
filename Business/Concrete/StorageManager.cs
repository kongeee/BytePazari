using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<Storage> Get(int storageId) {
            return new SuccessDataResult<Storage>(_storageDal.Get(a => a.StorageId == storageId), Messages.Smsg);
        }

        public IDataResult<List<Storage>> GetAll() {
            return new SuccessDataResult<List<Storage>>(_storageDal.GetAll(), Messages.Smsg);
        }
    }
}