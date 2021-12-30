using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IAddressService {
        IDataResult<List<Address>> GetAll();
        IDataResult<Address> Get(int addressId);
        IResult Add(Address address);
        IResult Update(Address address);
        IResult Delete(Address addreess);
        IDataResult<List<Address>> GetUserAddresses(int userId);

    }
}
