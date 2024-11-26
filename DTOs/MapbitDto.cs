using System.Drawing;

namespace Mapbit.DTOs
{
    public record MapbitDto(string fileName, string embedMessage, uint Height, uint Width, Color uniformColor);

    // public record SampleEntityDto(Guid Id, string Name,DestinationDto Destination, IEnumerable<SampleEntityItemDto> Items);
}
