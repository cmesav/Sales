﻿using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task seedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Name = "Argentina" });
                _context.Countries.Add(new Country {Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Ecuador" });
                _context.Countries.Add(new Country { Name = "Perú" });
            }
            await _context.SaveChangesAsync();
        }
    }
}