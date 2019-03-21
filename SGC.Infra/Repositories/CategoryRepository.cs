using SGC.Domain.Entities;
using SGC.Domain.Interfaces;
using SGC.Infra.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGC.Infra.Repositories
{
    /// <summary>
    /// Classe repositório de categoria de produto
    /// </summary>
    public class CategoryRepository : ICategoryRepository
    {
        public readonly SGCDataContext _dc;

        public CategoryRepository(SGCDataContext context)
        {
            _dc = context;
        }

        public IEnumerable<Category> getAllCategories()
        {
            try
            {
                return _dc.Categories.OrderBy(c => c.Name).ToList();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Error fetching categories, reason: " + ex.Message);
            }
        }

        public Category getCategory(int id)
        {
            try
            {
                return _dc.Categories.Find(id);
            }
            catch (Exception ex)
            {
                throw new System.Exception("Error fetching category, reason: " + ex.Message);
            }
        }
    }
}