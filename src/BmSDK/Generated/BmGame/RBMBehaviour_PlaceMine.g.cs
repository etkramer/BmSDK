#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_PlaceMine<br/>
/// (size = 400)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_PlaceMine : BmSDK.BmGame.RBMBehaviour_ActionQueue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_PlaceMine", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_PlaceMine() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_PlaceMine
    /// </summary>
    public RBMBehaviour_PlaceMine(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_PlaceMine Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_PlaceMine(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_PlaceMine.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OnEndInterrupt
    /// </summary>
    public unsafe override void OnEndInterrupt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_PlaceMine.OnEndInterrupt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_PlaceMine.OnActivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MinePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RThugMineablePointBase MinePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RThugMineablePointBase>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
}
