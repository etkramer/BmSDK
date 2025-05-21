namespace BmSDK;

public static class GameInfo
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
        public const IntPtr StaticFindObject = 0x87E80;
        public const IntPtr StaticConstructObject = 0x98BE0;
        public const IntPtr LoadPackage = 0x9FCA0;

        // UObject (local)
        public const IntPtr ProcessEvent = 0x46A60;
        public const IntPtr AddObject = 0x8E0A0;
        public const IntPtr ConditionalDestroy = 0x8C6C0;
        public const IntPtr FindFunction = 0x8A980;

        // FName (local)
        public const IntPtr NameInit = 0x7E990;

        // FString (local)
        public const IntPtr StringCtor = 0x4650;
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 0x4;
        public const IntPtr Object__Outer = 0x1C;
        public const IntPtr Object__Name = 0x20;
        public const IntPtr Object__Class = 0x28;
    }
}
