using System.Drawing;
using System.Reflection;
using System.Windows.Input;

namespace Mapbit.Commands
{
    public record CreateMapbit(string embedMessage,
        MapbitWriteModel MapbitModel) : ICommand;

    public record MapbitWriteModel(string fileName, string embedMessage, uint Height, uint Width, Color uniformColor);


    public record DecodeMapbit(string embedMessage,
        MapbitReadModel MapbitModel) : ICommand;
    

    public record EncodeMapbit(string embedMessage,
        MapbitReadModel MapbitModel) : ICommand;

    public record MapbitReadModel(string fileName, string embedMessage, uint Height, uint Width, Color uniformColor);


}
