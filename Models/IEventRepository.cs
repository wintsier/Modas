using System.Linq;
namespace Modas2.Models
{
    public interface IEventRepository
    {
        IQueryable<Event> Events { get; }
        IQueryable<Location> Locations { get; }
    }
}