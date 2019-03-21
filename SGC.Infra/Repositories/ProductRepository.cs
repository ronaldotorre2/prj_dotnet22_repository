using Microsoft.EntityFrameworkCore;
using SGC.Domain.Entities;
using SGC.Domain.Interfaces;
using SGC.Infra.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Infra.Repositories
{
    /// <summary>
    /// Classe repositório do produto
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        public readonly SGCDataContext _dc;

        public ProductRepository(SGCDataContext context)
        {
            _dc = context;
        }

        public IEnumerable<Product> getAllProducts()
        {
            try
            {
                return _dc.Products.Include("Category").OrderBy(p => p.Title).ToList();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Error fetching products, reason: " + ex.Message);
            }
        }

        public Product getProduct(int id)
        {
            try
            {
                var product = _dc.Products.Find(id);

                if (!string.IsNullOrEmpty(product.CategoryId.ToString()))
                {
                    product.Category = _dc.Categories.Find(product.CategoryId);
                }

                return product;
            }
            catch (Exception ex)
            {
                throw new System.Exception("Error fetching product, reason: " + ex.Message);
            }
        }
    }
}