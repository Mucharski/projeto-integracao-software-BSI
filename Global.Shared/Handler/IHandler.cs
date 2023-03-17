using System.Reflection.Metadata;
using Global.Shared.Generics;

namespace Global.Shared.Handler;

public interface IHandler<T>
{
    Task<GenericCommandResult> Handle(T command);
}