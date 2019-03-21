using SGC.Domain.Entities;
using System.Collections.Generic;

namespace SGC.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositório de produto
    /// </summary>
    public interface IProductRepository
    {
        IEnumerable<Product> getAllProducts();
        Product getProduct(int id);
    }
}