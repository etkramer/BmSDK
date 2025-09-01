namespace BmSDK.Framework;

internal static class GameInfo
{
    public static class GlobalOffsets
    {
#if BATMAN2
        public const IntPtr GNames = 0x11EC5E8;
        public const IntPtr GObjObjects = 0x122E900;
        public const IntPtr GError = 0x117BF48;
#elif BATMAN3
        public const IntPtr GNames = 0x14B1A98;
        public const IntPtr GObjObjects = 0x14B1ACC;
        public const IntPtr GError = 0x13EE784;
#endif
    }

    public static class FuncOffsets
    {
#if BATMAN2
        // app (global)
        public const IntPtr AppRealloc = 0x1EC10;

        // UObject (static)
        public const IntPtr StaticFindObject = 0x8ED20;
        public const IntPtr StaticConstructObject = 0x98BE0;
        public const IntPtr LoadPackage = 0x9FCA0;

        // UObject (local)
        public const IntPtr ProcessEvent = 0x46A60;
        public const IntPtr ProcessInternal = 0x468A0;
        public const IntPtr CallFunction = 0x4F8A0;
        public const IntPtr AddObject = 0x8E0A0;
        public const IntPtr ConditionalDestroy = 0x8C6C0;
        public const IntPtr FindFunction = 0x8A980;

        // UClass (local)
        public const IntPtr GetDefaultObject = 0x4C8E0;

        // UWorld (local)
        public const IntPtr SpawnActor = 0x321A20;

        // FName (local)
        public const IntPtr NameInit = 0x7E990;

        // FString (local)
        public const IntPtr StringCtor = 0x4650;
#elif BATMAN3
        // app (global)
        public const IntPtr AppRealloc = 0x1EF50;

        // UObject (static)
        public const IntPtr StaticFindObject = 0x86950;
        public const IntPtr StaticConstructObject = 0x8EE80;
        public const IntPtr LoadPackage = 0x92210;

        // UObject (local)
        public const IntPtr ProcessEvent = 0x428A0;
        public const IntPtr ProcessInternal = 0x42730;
        public const IntPtr CallFunction = 0x47E10;
        public const IntPtr AddObject = 0x834C0;
        public const IntPtr ConditionalDestroy = 0x841F0;
        public const IntPtr FindFunction = 0x84390;

        // UClass (local)
        public const IntPtr GetDefaultObject = 0x449C0;

        // UWorld (local)
        public const IntPtr SpawnActor = 0x329D30;

        // FName (local)
        public const IntPtr NameInit = 0x85180;

        // FString (local)
        public const IntPtr StringCtor = 0x4FF0;
#endif
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 4;
        public const IntPtr Object__Outer = 24;
        public const IntPtr Object__Name = 28;
        public const IntPtr Object__Class = 36;
    }
}
