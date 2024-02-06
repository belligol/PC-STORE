using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PC_STORE.BL.Interfaces;
using PC_STORE.DL2.Interfaces;
using PC_STORE.MODELS.Data;
using PC_STORE.MODELS.Request;

namespace PC_STORE.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<Product> GetById(int productId)
        {
            return await _productRepository.GetById(productId);
        }

        public async Task AddProduct(AddProductRequest productRequest)
        {
            var product = _mapper.Map<Product>(productRequest);

            await _productRepository.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _productRepository.UpdateProduct(product);
        }

        public async Task DeleteProduct(int productId)
        {
            await _productRepository.DeleteProduct(productId);
        }
    }
}

