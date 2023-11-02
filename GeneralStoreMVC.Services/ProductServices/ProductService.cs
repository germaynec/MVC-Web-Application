using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreMVC.Models.ProductModels;

namespace GeneralStoreMVC.Services.ProductServices;

public class ProductService : IProductService
{
    public Task<ProductIndex?> CreateNewProductAsync(ProductCreate request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditProductInfoAsync(ProductEdit request)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProductIndex>> GetAllProductAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductDetail?> GetProductByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductEdit?> GetProductByIdForEditAsync(int id)
    {
        throw new NotImplementedException();
    }
}
