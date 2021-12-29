using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete {
    public class ProductImageManager:IProductImageService {
        IProductImageDal _productImageDal;
        IFileHelper _fileHelper;
        public ProductImageManager(IProductImageDal productImageDal, IFileHelper fileHelper) {
            _productImageDal = productImageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, ProductImage productImage) {
            
            
            productImage.Path = _fileHelper.Upload(file, "wwwroot\\Uploads\\Images\\");
            productImage.Date = DateTime.Now;
            _productImageDal.Add(productImage);
            return new SuccessResult(Messages.Smsg);
        }

        public IResult Delete(ProductImage productImage) {
            _fileHelper.Delete("wwwroot\\Uploads\\Images\\" + productImage.Path);
            _productImageDal.Delete(productImage);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, ProductImage productImage) {
            productImage.Path = _fileHelper.Update(file, "wwwroot\\Uploads\\Images\\" + productImage.Path, "wwwroot\\Uploads\\Images\\");
            _productImageDal.Update(productImage);
            return new SuccessResult();
        }

        public IDataResult<List<ProductImage>> GetByProductId(int productId) {
            
           
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll(c => c.ProductId == productId));
        }

        public IDataResult<ProductImage> GetByImageId(int imageId) {
            return new SuccessDataResult<ProductImage>(_productImageDal.Get(pi => pi.ImageId == imageId));
        }

        public IDataResult<List<ProductImage>> GetAll() {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }
      
        private IDataResult<List<ProductImage>> GetDefaultImage(int productId) {

            List<ProductImage> productImage = new List<ProductImage>();
            productImage.Add(new ProductImage { ProductId = productId, Date = DateTime.Now, Path = "DefaultImage.jpg" });
            return new SuccessDataResult<List<ProductImage>>(productImage);
        }
      
    }
}
