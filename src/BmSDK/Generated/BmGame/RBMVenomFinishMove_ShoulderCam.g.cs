#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMVenomFinishMove_ShoulderCam<br/>
/// (size = 188)
/// (flags = 18)
/// </summary>
public partial class RBMVenomFinishMove_ShoulderCam : BmSDK.BmGame.RBMDeathCutscene_Cam, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMVenomFinishMove_ShoulderCam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMVenomFinishMove_ShoulderCam() { }

    /// <summary>
    /// Constructs a new RBMVenomFinishMove_ShoulderCam
    /// </summary>
    public RBMVenomFinishMove_ShoulderCam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMVenomFinishMove_ShoulderCam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMVenomFinishMove_ShoulderCam(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMVenomFinishMove_ShoulderCam.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetViewTarget
    /// </summary>
    public unsafe override void ResetViewTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMVenomFinishMove_ShoulderCam.ResetViewTarget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMVenomFinishMove_ShoulderCam.Tick", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckStartPosition
    /// </summary>
    public unsafe virtual void CheckStartPosition(System.Numerics.Vector3 StartPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMVenomFinishMove_ShoulderCam.CheckStartPosition", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override bool OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMVenomFinishMove_ShoulderCam.OnActivate", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanUseCam
    /// </summary>
    public unsafe static bool CanUseCam(BmSDK.BmGame.RBMCutsceneBase CheckCutscene)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMVenomFinishMove_ShoulderCam.CanUseCam", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCutscene, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// StructProperty: CamStartPos
    /// </summary>
    public unsafe System.Numerics.Vector3 CamStartPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
}
