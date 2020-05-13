using eShopSolutionIT.ViewModels.Catalog.Products;
using eShopSolutionIT.ViewModels.Catalog.Products.Public;
using eShopSolutionIT.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopSolutionIT.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
