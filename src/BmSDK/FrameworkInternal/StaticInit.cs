using System.Reflection;

namespace BmSDK.Framework;

static partial class StaticInit
{
    const BindingFlags FuncSearchFlags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;

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

    /// <summary>
    /// Returns an enumerable collection of the specified type and all its base types, starting from the given type and
    /// traversing up the inheritance hierarchy.
    /// </summary>
    /// <param name="type">The type from which to begin enumeration. Must not be null.</param>
    /// <returns>An enumerable sequence of <see cref="Type"/> objects, beginning with <paramref name="type"/> and followed by
    /// each of its base types up to the root.</returns>
    public static IEnumerable<Type> EnumerateSelfAndSupers(Type type)
    {
        for (var cur = type; cur != null; cur = cur.BaseType)
        {
            yield return cur;
        }
    }

    /// <summary>
    /// This function enumerates all supers until it finds the first class that declares the requested method.
    /// This is necessary so a method of a non-declaring subclass can be redirected.
    /// </summary>
    /// <param name="type">The type at the bottom of the hierarchy to go up from</param>
    /// <param name="methodName">The name of the method to seach for</param>
    /// <returns>The declaring type</returns>
    /// <exception cref="ArgumentException">If the method couldn't be found.</exception>
    public static Type GetDeclaringTypeForMethod(Type type, string methodName)
        => Guard.NotNull(EnumerateSelfAndSupers(type)
            .FirstOrDefault(super => super.GetMethod(methodName, FuncSearchFlags) != null),
            $"Couldn't find declaring class for method {methodName}!");

    /// <summary>
    /// Gets the fully qualified path of the method definition for the given type in the UE3 format.
    /// </summary>
    /// <remarks>If the specified method is inherited, the path will refer to the base type where the method
    /// is originally declared.</remarks>
    /// <param name="type">The type to search for the method declaration. This can be a derived type; the method's actual declaring type
    /// will be resolved.</param>
    /// <param name="methodName">The name of the method whose defining type path is to be retrieved.</param>
    /// <returns>A string representing the path to the method definition: "Namespace.Type:MethodName".</returns>
    public static string GetDeclaringFuncPath(Type type, string methodName)
    {
        var declaringType = GetDeclaringTypeForMethod(type, methodName);
        var declaringTypePath = GetClassPathForManagedType(declaringType);
        return $"{declaringTypePath}:{methodName}";
    }
}
