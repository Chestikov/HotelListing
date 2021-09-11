using HotelListing.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> CountriesRepo {  get; }

        IGenericRepository<Hotel> HotelsRepo {  get; }

        Task Save();
    }
}
