﻿namespace SportStore.Models
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _context;
        public StoreRepository(StoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => _context.Products;
    }
}
