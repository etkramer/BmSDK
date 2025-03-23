using System.Diagnostics.CodeAnalysis;

namespace BmSDK.Generator.Utils;

public struct DisposableBlock(Action onClose) : IDisposable
{
    public DisposableBlock(Action onOpen, Action onClose)
        : this(onClose)
    {
        onOpen.Invoke();
    }

    public readonly void Dispose() => onClose();
}
