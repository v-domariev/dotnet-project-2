using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using HotelSystem2.Server.Entities;

namespace HotelSystem2.Server.Context
{
    public interface IHotelContext
    {
        DbSet<Hotel> Hotels { get; set; }
        //Task SaveChangesAsync();
    }
}
