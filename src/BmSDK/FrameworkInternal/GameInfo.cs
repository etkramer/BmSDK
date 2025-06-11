namespace BmSDK.Framework;

internal static class GameInfo
{
    public static class GlobalOffsets
    {
        public const IntPtr GNames = 0x11EC5E8;
        public const IntPtr GObjObjects = 0x122E900;
        public const IntPtr GError = 0x117BF48;
    }

    public static class FuncOffsets
    {
        // UObject (static)
        public const IntPtr StaticFindObject = 0x8ED20;
        public const IntPtr StaticConstructObject = 0x98BE0;
        public const IntPtr LoadPackage = 0x9FCA0;

        // UObject (local)
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
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 4;
        public const IntPtr Object__Outer = 24;
        public const IntPtr Object__Name = 28;
        public const IntPtr Object__Class = 36;
    }
}
