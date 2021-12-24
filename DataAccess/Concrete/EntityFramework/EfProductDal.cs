using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework {
    public class EfProductDal : EfEntityRepositoryBase<Product, BytePazariContext>, IProductDal {
        public List<ProductDetailDto> GetProductDetails(int productId) {
            using(BytePazariContext context = new BytePazariContext()) {
                var result = from p in context.Products
                             join b in context.Brands on p.BrandId equals b.BrandId
                             join c in context.Cpu on p.CpuId equals c.CpuId
                             join g in context.Gpu on p.GpuId equals g.GpuId
                             join r in context.Ram on p.RamId equals r.RamId
                             join s in context.Storage on p.StorageId equals s.StorageId
                             where p.ProductId == productId
                             select new ProductDetailDto {
                                 ProductId = p.ProductId,
                                 ProductName = p.Name,
                                 Price = p.Price,
                                 Monitor = p.Monitor,
                                 Rating = p.Rating,
                                 Stock = p.Stock,
                                 BrandName = b.Name,
                                 CpuName = c.Name,
                                 GpuName = g.Name,
                                 RamName = r.Name,
                                 SsdCapacity = s.SsdCapacity,
                                 HddCapacity = s.HddCapacity,

                             };
                return result.ToList();
            }

        }




    }
}
