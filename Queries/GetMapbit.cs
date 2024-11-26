using Mapbit.Abstractions.Queries;
using Mapbit.DTOs;

namespace Mapbit.Queries
{
    public class GetMapbit : IQuery<MapbitDto>
    {
        public Guid Id { get; set; }
    }
}
