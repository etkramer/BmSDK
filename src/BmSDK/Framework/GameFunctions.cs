using BmSDK.Framework;

namespace BmSDK;

public static class GameFunctions
{
    // UObject::StaticConstructObject()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr StaticConstructObjectDelegate(
        IntPtr InClass,
        IntPtr InOuter,
        FName InName,
        EObjectFlags InFlags,
        IntPtr InTemplate,
        IntPtr Error,
        IntPtr SubobjectRoot,
        IntPtr InInstanceGraph
    );

    // UObject::StaticFindObject()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr StaticFindObjectDelegate(
        IntPtr Class,
        IntPtr InOuter,
        IntPtr OrigInName,
        int ExactClass
    );

    // UObject::LoadPackage()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr LoadPackageDelegate(IntPtr InOuter, IntPtr Filename, int LoadFlags);

    // UObject::ProcessEvent()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessEventDelegate(
        IntPtr self,
        IntPtr Function,
        IntPtr Parms,
        IntPtr UnusedResult
    );

    // UObject::CallFunction()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void CallFunctionDelegate(
        IntPtr self,
        IntPtr Stack,
        IntPtr Result,
        IntPtr Function
    );

    // UObject::AddObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void AddObjectDelegate(IntPtr self, int InIndex);

    // UObject::~UObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ConditionalDestroyDelegate(IntPtr self);

    // UObject::FindFunction()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate IntPtr FindFunctionDelegate(IntPtr self, FName InName, int Global);

    // FName::Init()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void NameInitDelegate(
        IntPtr self,
        IntPtr InName,
        int InNumber,
        int FindType,
        int bSplitName
    );

    // FString::FString()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate IntPtr StringCtorDelegate(IntPtr self, IntPtr In);

    static StaticConstructObjectDelegate? _StaticConstructObject = null;
    static StaticFindObjectDelegate? _StaticFindObject = null;
    static LoadPackageDelegate? _LoadPackage = null;
    static ProcessEventDelegate? _ProcessEvent = null;
    static CallFunctionDelegate? _CallFunction = null;
    static AddObjectDelegate? _AddObject = null;
    static ConditionalDestroyDelegate? _ConditionalDestroy = null;
    static FindFunctionDelegate? _FindFunction = null;
    static NameInitDelegate? _NameInit = null;
    static StringCtorDelegate? _StringCtor = null;

    public static StaticConstructObjectDelegate StaticConstructObject =>
        _StaticConstructObject ??=
            Marshal.GetDelegateForFunctionPointer<StaticConstructObjectDelegate>(
                MemUtil.GetIntPointer(GameInfo.FuncOffsets.StaticConstructObject)
            );

    public static StaticFindObjectDelegate StaticFindObject =>
        _StaticFindObject ??= Marshal.GetDelegateForFunctionPointer<StaticFindObjectDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.StaticFindObject)
        );

    public static LoadPackageDelegate LoadPackage =>
        _LoadPackage ??= Marshal.GetDelegateForFunctionPointer<LoadPackageDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.LoadPackage)
        );

    public static ProcessEventDelegate ProcessEvent =>
        _ProcessEvent ??= Marshal.GetDelegateForFunctionPointer<ProcessEventDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.ProcessEvent)
        );

    public static CallFunctionDelegate CallFunction =>
        _CallFunction ??= Marshal.GetDelegateForFunctionPointer<CallFunctionDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.CallFunction)
        );

    public static AddObjectDelegate AddObject =>
        _AddObject ??= Marshal.GetDelegateForFunctionPointer<AddObjectDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.AddObject)
        );

    public static ConditionalDestroyDelegate ConditionalDestroy =>
        _ConditionalDestroy ??= Marshal.GetDelegateForFunctionPointer<ConditionalDestroyDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.ConditionalDestroy)
        );

    public static FindFunctionDelegate FindFunction =>
        _FindFunction ??= Marshal.GetDelegateForFunctionPointer<FindFunctionDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.FindFunction)
        );

    public static NameInitDelegate NameInit =>
        _NameInit ??= Marshal.GetDelegateForFunctionPointer<NameInitDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.NameInit)
        );

    public static StringCtorDelegate StringCtor =>
        _StringCtor ??= Marshal.GetDelegateForFunctionPointer<StringCtorDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.StringCtor)
        );
}
