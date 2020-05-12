using eShopSolutionIT.Application.Catalog.Products.Dtos;
using eShopSolutionIT.Application.Catalog.Products.Dtos.Public;
using eShopSolutionIT.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolutionIT.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
