using System.Drawing;
using System.Reflection;
using System.Windows.Input;

namespace Mapbit.Commands
{
    public record CreateMapbit(string embedMessage,
        MapbitWriteModel MapbitModel) : ICommand;

    public record MapbitWriteModel(string fileName, string embedMessage, uint Height, uint Width, Color uniformColor);
}
