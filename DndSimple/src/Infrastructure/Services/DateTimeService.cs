using DndSimple.Application.Common.Interfaces;

namespace DndSimple.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
