using Mapbit.Abstractions.Queries;
using Mapbit.DTOs;

namespace Mapbit.Queries
{
    public class GetMapbit : IQuery<MapbitDto>
    {
        public string Filename { get; set; }
    }

    public record GetMessageQuery() : IQuery<MapbitDto>;
}
