namespace BmSDK.Framework;

internal static class FindObjectsCache
{
    private static readonly Dictionary<Type, LinkedList<GameObject>> s_objectsByType = [];
    private static readonly Dictionary<GameObject, LinkedListNode<GameObject>[]> s_removalCache =
    [];

    public static IEnumerable<T> FindObjects<T>()
        where T : GameObject
    {
        if (!s_objectsByType.TryGetValue(typeof(T), out var objects))
        {
            return [];
        }

        return EnumerateObjects<T>(objects);
    }

    public static void Register(GameObject obj)
    {
        if (!obj.IsValid || s_removalCache.ContainsKey(obj))
        {
            return;
        }

        var nodes = new List<LinkedListNode<GameObject>>();
        for (
            var type = obj.GetType();
            type != null && typeof(GameObject).IsAssignableFrom(type);
            type = type.BaseType
        )
        {
            if (!s_objectsByType.TryGetValue(type, out var objects))
            {
                objects = [];
                s_objectsByType[type] = objects;
            }

            nodes.Add(objects.AddLast(obj));
        }

        s_removalCache[obj] = [.. nodes];
    }

    public static void Unregister(GameObject obj)
    {
        if (!s_removalCache.Remove(obj, out var bucketNodes))
        {
            return;
        }

        foreach (var node in bucketNodes)
        {
            node.List?.Remove(node);
        }
    }

    private static IEnumerable<T> EnumerateObjects<T>(LinkedList<GameObject> objects)
        where T : GameObject
    {
        for (var node = objects.First; node != null; node = node.Next)
        {
            yield return (T)node.Value;
        }
    }
}
