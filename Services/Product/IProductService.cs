using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreAPI_Template_v2.DTOs.Product;
using NetCoreAPI_Template_v2.Models;

namespace NetCoreAPI_Template_v2.Services.Product
{
    public interface IProductService
    {
        Task<ServiceResponse<List<GetProductDto>>> GetAllProducts();
    }
}