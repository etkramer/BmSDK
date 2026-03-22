#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInteractionManager<br/>
/// (size = 128)
/// (flags = 134217874)
/// </summary>
public partial class RInteractionManager : BmSDK.Component, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInteractionManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInteractionManager() { }

    /// <summary>
    /// Constructs a new RInteractionManager
    /// </summary>
    public RInteractionManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInteractionManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInteractionManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: UnRegisterActor
    /// </summary>
    public unsafe virtual void UnRegisterActor(BmSDK.Engine.RInteractionComponent ActorToRemove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RInteractionManager.UnRegisterActor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorToRemove, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: RegisterNewActor
    /// </summary>
    public unsafe virtual void RegisterNewActor(BmSDK.Engine.RInteractionComponent NewActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RInteractionManager.RegisterNewActor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActor, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetInteractionClass
    /// </summary>
    public unsafe virtual BmSDK.Engine.RInteractionClass GetInteractionClass(BmSDK.FName ClassName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RInteractionManager.GetInteractionClass", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClassName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(paramsPtr + 8);
    }

    /// <summary>
    /// MapProperty: InteractionClasses
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ InteractionClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RInteractionClass> ReferencedClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RInteractionClass>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
