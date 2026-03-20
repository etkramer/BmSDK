namespace BmSDK.Framework;

internal static class GameInfo
{
    public static class GlobalOffsets
    {
#if BATMAN2
        public const IntPtr GNames = 0x3A208B8;
        public const IntPtr GObjObjects = 0x340CBE4;
        public const IntPtr GError = 0x117BF48;
#elif BATMAN3
        public const IntPtr GNames = 0x14B1A98;
        public const IntPtr GObjObjects = 0x14B1ACC;
        public const IntPtr GError = 0x13EE784;
#endif
    }

    public static class FuncOffsets
    {
        // app (global)
        public const IntPtr AppRealloc = 0x1EC10;
        public const IntPtr AppFree = 0x1EC30;
        public const IntPtr EngineTick = 0x7D8980;

        // UObject (static)
        public const IntPtr StaticFindObject = 0xF3B7F0;
        public const IntPtr StaticConstructObject = 0x98BE0;
        public const IntPtr LoadPackage = 0x9FCA0;

        // UObject (local)
        public const IntPtr ProcessEvent = 0xF90CD0;
        public const IntPtr ProcessInternal = 0xF90B30;
        public const IntPtr CallFunction = 0x4F8A0;
        public const IntPtr AddObject = 0x8E0A0;
        public const IntPtr ConditionalDestroy = 0x8C6C0;
        public const IntPtr FindFunction = 0x8A980;
        public const IntPtr ConditionalPostLoad = 0x9A110;

        // UClass (local)
        public const IntPtr GetDefaultObject = 0x4C8E0;

        // UWorld (local)
        public const IntPtr SpawnActor = 0x321A20;

        // FName (local)
        public const IntPtr NameInit = 0xF37BF0;

        // FString (local)
        public const IntPtr StringCtor = 0x4650;
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 4;
        public const IntPtr Object__Outer = 24;
        public const IntPtr Object__Name = 28;
        public const IntPtr Object__Class = 36;
        public const IntPtr Class__ClassFlags = 180;
    }
}
