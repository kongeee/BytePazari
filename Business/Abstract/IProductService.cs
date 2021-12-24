using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IProductService {
        List<Product> GetAll();
        List<Product> GetAllByBrandId(int brandId);
        List<Product> GetAllByPrice(int min, int max);
        Product Get(int productId);

        List<ProductDetailDto> GetProductDetails(int productId);
    }
}
