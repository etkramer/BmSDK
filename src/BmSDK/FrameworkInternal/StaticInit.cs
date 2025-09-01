namespace BmSDK.Framework;

internal static partial class StaticInit
{
    public static Type GetManagedTypeForClassPath(string classPath)
    {
        return _classPathToManagedTypeMap.TryGetValue(classPath, out var res)
            ? res
            : typeof(IntrinsicDummy);
    }

    public static string GetClassPathForManagedType(Type type)
    {
        _managedTypeToClassPathMap.TryGetValue(type, out var res);
        return Guard.NotNull(res);
    }
}
