using ECommerceAPI.Application.Interfaces;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            // await _productWriteRepository.AddRangeAsync(new()
            // {
            //     new() { Id = Guid.NewGuid(), Name = "Product 1 ", Price = 100, CreatedDate = DateTime.Now, Stock = 10
            //     }
            // });
            //var count = await _productWriteRepository.SaveAsync();

           Product p = await _productReadRepository.GetByIdAsync("");
            p.Name = "Gökan";
            await _productWriteRepository.SaveAsync();
        }
    }
}
