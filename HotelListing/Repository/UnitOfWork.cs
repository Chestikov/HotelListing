using HotelListing.Data;
using HotelListing.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _dbContext;
        private IGenericRepository<Country> _countriesRepo;
        private IGenericRepository<Hotel> _hotelsRepo;

        public UnitOfWork(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IGenericRepository<Country> CountriesRepo => _countriesRepo ??= new GenericRepository<Country>(_dbContext);
        public IGenericRepository<Hotel> HotelsRepo => _hotelsRepo ??= new GenericRepository<Hotel>(_dbContext);

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
