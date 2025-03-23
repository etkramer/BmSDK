using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmSDK;

[Flags]
public enum EObjectFlags : ulong
{
    RF_InSingularFunc = 0x2,
    RF_StateChanged = 0x4,
    RF_DebugPostLoad = 0x8,
    RF_DebugSerialize = 0x10,
    RF_DebugFinishDestroyed = 0x20,
    RF_EdSelected = 0x40,
    RF_ZombieComponent = 0x80,
    RF_Protected = 0x100,
    RF_ClassDefaultObject = 0x200,
    RF_ArchetypeObject = 0x400,
    RF_ForceTagExp = 0x800,
    RF_TokenStreamAssembled = 0x1000,
    RF_MisalignedObject = 0x2000,
    RF_RootSet = 0x4000,
    RF_BeginDestroyed = 0x8000,
    RF_FinishDestroyed = 0x10000,
    RF_DebugBeginDestroyed = 0x20000,
    RF_MarkedByCooker = 0x40000,
    RF_LocalizedResource = 0x80000,
    RF_InitializedProps = 0x100000,
    RF_PendingFieldPatches = 0x200000,

    RF_Saved = 0x80000000,
    RF_Transactional = 0x100000000,
    RF_Unreachable = 0x200000000,
    RF_Public = 0x400000000,
    RF_TagImp = 0x800000000,
    RF_TagExp = 0x1000000000,
    RF_Obsolete = 0x2000000000,
    RF_TagGarbage = 0x4000000000,
    RF_DisregardForGC = 0x8000000000,
    RF_PerObjectLocalized = 0x10000000000,
    RF_NeedLoad = 0x20000000000,
    RF_AsyncLoading = 0x40000000000,
    RF_NeedPostLoadSubobjects = 0x80000000000,
    RF_Suppress = 0x100000000000,
    RF_InEndState = 0x200000000000,
    RF_Transient = 0x400000000000,
    RF_Cooked = 0x800000000000,
    RF_LoadForClient = 0x1000000000000,
    RF_LoadForServer = 0x2000000000000,
    RF_LoadForEdit = 0x4000000000000,
    RF_Standalone = 0x8000000000000,
    RF_NotForClient = 0x10000000000000,
    RF_NotForServer = 0x20000000000000,
    RF_NotForEdit = 0x40000000000000,

    RF_NeedPostLoad = 0x100000000000000,
    RF_HasStack = 0x200000000000000,
    RF_Native = 0x400000000000000,
    RF_Marked = 0x800000000000000,
    RF_ErrorShutdown = 0x1000000000000000,
    RF_PendingKill = 0x2000000000000000,
}
