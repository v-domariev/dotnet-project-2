using HotelSystem2.Server.Entities;

namespace HotelSystem2.Server.Services
{
    public interface IHotelService
    {
        Task<IList<Hotel>> GetHotelsAsync();
    }
}
