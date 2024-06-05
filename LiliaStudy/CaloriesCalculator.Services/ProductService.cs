
using CaloriesCalculator.Interface.Repository;
using CaloriesCalculator.Interface.Services;
using CaloriesCalculator.Interface.Services.DTO;
using CaloriesCalculator.Models;

namespace CaloriesCalculator.Services
{
    public class ProductService : IProductService
    {
        private readonly IEntityRepository<Product> _productRepository;

        public ProductService(IEntityRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public int Create(CreateProductDTO createProductDTO)
        {
            
            var productToCreate = new Product()
            {
                Name = createProductDTO.Name,
                CaloriePer100Gram = createProductDTO.CaloriePer100Gram,
                FatPer100Gram = createProductDTO.FatPer100Gram,
                ProteinPer100Gram = createProductDTO.ProteinPer100Gram,
                CarbohydratesPer100Gram = createProductDTO.CarbohydratesPer100Gram
            };
            return _productRepository.Create(productToCreate);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public ProductCardDTO Get(int id)
        {
            var product = _productRepository.Get(id);
            var card = new ProductCardDTO()
            {
                Id = product.Id,
                Name = product.Name,
               CaloriePer100Gram = product.CaloriePer100Gram,
            };
            return card;
        }

        public IEnumerable<ProductCardDTO> GetAll()
        {
            return _productRepository.GetAll().Select(product => new ProductCardDTO()
            {
                Id = product.Id,
                Name = product.Name,
                CaloriePer100Gram = product.CaloriePer100Gram,
            });
        }

        public void Update(int id, UpdateProductDTO updateProductDTO)
        {
            var producttoupdate = _productRepository.Get(id);

            producttoupdate.Name = updateProductDTO.Name;
            producttoupdate.FatPer100Gram = updateProductDTO.FatPer100Gram;
            producttoupdate.ProteinPer100Gram = updateProductDTO.ProteinPer100Gram;
            producttoupdate.CarbohydratesPer100Gram = updateProductDTO.CarbohydratesPer100Gram;
            producttoupdate.CaloriePer100Gram = updateProductDTO.CaloriePer100Gram ;

            _productRepository.Update(id, producttoupdate);
        }
    }
}
