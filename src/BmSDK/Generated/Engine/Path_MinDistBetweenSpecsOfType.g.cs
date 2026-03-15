#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Path_MinDistBetweenSpecsOfType<br/>
/// (size = 72)
/// (flags = 134217874)
/// </summary>
public partial class Path_MinDistBetweenSpecsOfType : BmSDK.Engine.PathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Path_MinDistBetweenSpecsOfType", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Path_MinDistBetweenSpecsOfType() { }

    /// <summary>
    /// Constructs a new Path_MinDistBetweenSpecsOfType
    /// </summary>
    public Path_MinDistBetweenSpecsOfType(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Path_MinDistBetweenSpecsOfType Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Path_MinDistBetweenSpecsOfType(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Recycle
    /// </summary>
    public unsafe void Recycle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.Path_MinDistBetweenSpecsOfType.Recycle", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: MinDistBetweenSpecTypes
    /// </summary>
    public unsafe float MinDistBetweenSpecTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// StructProperty: InitLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 InitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ClassProperty: ReachSpecClass
    /// </summary>
    public unsafe BmSDK.Class ReachSpecClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }
}
