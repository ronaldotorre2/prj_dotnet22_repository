using SGC.Domain.Entities;
using System.Collections.Generic;

namespace SGC.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositório de categoria
    /// </summary>
    public interface ICategoryRepository
    {
        IEnumerable<Category> getAllCategories();
        Category getCategory(int id);
    }
}