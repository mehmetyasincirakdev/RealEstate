﻿using Dapper;
using RealEstate.Models.DapperContext;
using RealEstate.Models.DTOs;
using RealEstate.Models.DTOs.CategoryDTOs;
using RealEstate.Models.DTOs.ProductDTOs;

namespace RealEstate.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync()
        {
            string query =
                "SELECT ProductId,ProductTitle,ProductPrice,ProductCity,ProductDistrict,CategoryName from Product inner join Category on Product.ProductCategory=Category.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
