using CaloriesCalculator.Interface.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services
{
    public interface IProductService
    {
        int Create(CreateProductDTO createProductDTO);
        void Update(int id, UpdateProductDTO updateProductDTO);
        ProductCardDTO Get(int id);
        void Delete(int id);
    }
}
