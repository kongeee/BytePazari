using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Address address) {
            
            if(address.AddressInfo.Length < 0) {
                return new ErrorResult(Messages.Emsg_21);
            }

            _addressDal.Add(address);
            return new SuccessResult(Messages.Smsg);
        }

        public IResult Delete(Address addreess) {
            _addressDal.Delete(addreess);
            return new SuccessResult(Messages.Smsg);
        }

        public IDataResult<Address> Get(int addressId) {
            return new SuccessDataResult<Address> (_addressDal.Get(a => a.AddressId == addressId), Messages.Smsg);
        }

        public IDataResult<List<Address>> GetUserAddresses(int userId) {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(a => a.UserId == userId), Messages.Smsg);
        }

        public IDataResult<List<Address>> GetAll() {
            return new SuccessDataResult<List<Address>> (_addressDal.GetAll(), Messages.Smsg);
        }

        public IResult Update(Address address) {
            _addressDal.Update(address);
            return new SuccessResult(Messages.Smsg);
        }
    }
}
