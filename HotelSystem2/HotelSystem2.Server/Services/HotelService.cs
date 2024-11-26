using HotelSystem2.Server.Context;
using HotelSystem2.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem2.Server.Services
{
    public class HotelService : IHotelService
    {

        private IHotelContext _context;
        public HotelService(IHotelContext hotelContext)
        {
            _context = hotelContext;
        }


        public async Task<IList<Hotel>> GetHotelsAsync() 
        {
            return await _context.Hotels.ToListAsync();

        }

    }
}
