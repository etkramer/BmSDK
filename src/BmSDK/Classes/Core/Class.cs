using System.Reflection;
using BmSDK.Framework;

namespace BmSDK;

public partial class Class
{
    const BindingFlags FuncSearchFlags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;

    /// <summary>
    /// Gets the default object for this class.
    /// </summary>
    public unsafe GameObject DefaultObject
    {
        get
        {
            var ptr = GameFunctions.GetDefaultObject(Ptr, 0);
            return MarshalUtil.ToManaged<GameObject>(&ptr);
        }
    }

    /// <summary>
    /// Returns the matching Type object for this class.
    /// </summary>
    public Type GetManagedType() => StaticInit.GetManagedTypeForClassPath(GetPathName());

    /// <summary>
    /// Returns the matching Class object for the given type.
    /// </summary>
    public static Class FindByManagedType(Type type)
    {
        return StaticFindObjectChecked<Class>(
            null,
            null,
            StaticInit.GetClassPathForManagedType(type),
            false
        );
    }

    public static IEnumerable<Type> EnumerateSupersAndSelf(Type type)
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
        => Guard.NotNull(EnumerateSupersAndSelf(type)
            .FirstOrDefault(super => super.GetMethod(methodName, FuncSearchFlags) != null),
            $"Couldn't find declaring class for method {methodName}!");
}
