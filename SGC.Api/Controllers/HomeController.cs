using Microsoft.AspNetCore.Mvc;
using SGC.Domain.Entities;
using SGC.Domain.Interfaces;
using System.Collections.Generic;

namespace sgc.api.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public HomeController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        [HttpGet]
        public IEnumerable<Product> get(){
            return _ProductRepository.getAllProducts();
        }
    }
}