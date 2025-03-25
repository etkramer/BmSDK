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

    // UObject::ProcessEvent()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessEventDelegate(
        IntPtr self,
        IntPtr Function,
        IntPtr Parms,
        IntPtr UnusedResult
    );

    // UObject::ProcessEvent()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void AddObjectDelegate(IntPtr self, int InIndex);

    // UObject::~UObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ObjectDtorDelegate(IntPtr self);

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

    static StaticConstructObjectDelegate? _StaticConstructObject = null;
    static StaticFindObjectDelegate? _StaticFindObject = null;
    static ProcessEventDelegate? _ProcessEvent = null;
    static AddObjectDelegate? _AddObject = null;
    static ObjectDtorDelegate? _ObjectDtor = null;
    static NameInitDelegate? _NameInit = null;
    static FindFunctionDelegate? _FindFunction = null;

    public static StaticConstructObjectDelegate StaticConstructObject =>
        _StaticConstructObject ??=
            Marshal.GetDelegateForFunctionPointer<StaticConstructObjectDelegate>(
                MemUtil.GetIntPointer(GameInfo.FuncOffsets.StaticConstructObject)
            );

    public static StaticFindObjectDelegate StaticFindObject =>
        _StaticFindObject ??= Marshal.GetDelegateForFunctionPointer<StaticFindObjectDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.StaticFindObject)
        );

    public static ProcessEventDelegate ProcessEvent =>
        _ProcessEvent ??= Marshal.GetDelegateForFunctionPointer<ProcessEventDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.ProcessEvent)
        );

    public static AddObjectDelegate AddObject =>
        _AddObject ??= Marshal.GetDelegateForFunctionPointer<AddObjectDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.AddObject)
        );

    public static ObjectDtorDelegate ObjectDtor =>
        _ObjectDtor ??= Marshal.GetDelegateForFunctionPointer<ObjectDtorDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.ObjectDtor)
        );

    public static NameInitDelegate NameInit =>
        _NameInit ??= Marshal.GetDelegateForFunctionPointer<NameInitDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.NameInit)
        );

    public static FindFunctionDelegate FindFunction =>
        _FindFunction ??= Marshal.GetDelegateForFunctionPointer<FindFunctionDelegate>(
            MemUtil.GetIntPointer(GameInfo.FuncOffsets.FindFunction)
        );
}
