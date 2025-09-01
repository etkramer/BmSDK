namespace BmSDK.Framework;

internal static partial class StaticInit
{
    public static Type GetManagedTypeForClassPath(string classPath)
    {
        if (_classPathToManagedTypeMap.TryGetValue(classPath, out var res))
        {
            return res;
        }

        // Debug.LogWarning($"Couldn't find managed type for class '{classPath}'");
        return typeof(IntrinsicDummy);
    }

    public static string GetClassPathForManagedType(Type type)
    {
        _managedTypeToClassPathMap.TryGetValue(type, out var res);
        return Guard.NotNull(res);
    }
}
