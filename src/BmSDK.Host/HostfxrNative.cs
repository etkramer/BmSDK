using System.Runtime.InteropServices;

namespace BmSDK.Host;

/// <summary>
/// P/Invoke declarations for nethost and hostfxr APIs.
/// </summary>
static partial class HostfxrNative
{
    // nethost
    [LibraryImport("nethost", StringMarshalling = StringMarshalling.Utf16)]
    public static partial int get_hostfxr_path(
        Span<char> buffer,
        ref int bufferSize,
        nint parameters);

    // hostfxr
    [LibraryImport("hostfxr", StringMarshalling = StringMarshalling.Utf16)]
    public static partial int hostfxr_initialize_for_runtime_config(
        string runtimeConfigPath,
        nint parameters,
        out nint hostContextHandle);

    [LibraryImport("hostfxr")]
    public static partial int hostfxr_get_runtime_delegate(
        nint hostContextHandle,
        HostfxrDelegateType type,
        out nint @delegate);

    [LibraryImport("hostfxr")]
    public static partial int hostfxr_close(nint hostContextHandle);

    public enum HostfxrDelegateType
    {
        hdt_load_assembly_and_get_function_pointer = 5,
    }

    // Delegate type for load_assembly_and_get_function_pointer
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int LoadAssemblyAndGetFunctionPointerFn(
        string assemblyPath,
        string typeName,
        string methodName,
        nint delegateTypeNative,
        nint reserved,
        out nint functionPointer);

    // Sentinel value indicating [UnmanagedCallersOnly] method
    public static readonly nint UNMANAGEDCALLERSONLY_METHOD = -1;
}
