using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class AddressManager : IAddressService {

        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal) {
            _addressDal = addressDal;
        }

        public Address Get(int addressId) {
            return _addressDal.Get(a => a.AddressId == addressId);
        }

        public List<Address> GetAll() {
            return _addressDal.GetAll();
        }
    }
}
