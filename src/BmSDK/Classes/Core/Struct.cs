using BmSDK.Framework;

namespace BmSDK;

public partial class Struct
{
    /// <summary>
    /// Property: Children
    /// </summary>
    public Struct SuperStruct
    {
        get => MarshalUtil.ToManaged<Struct>(Ptr + 92);
    }

    /// <summary>
    /// Property: Children
    /// </summary>
    public Field Children
    {
        get => MarshalUtil.ToManaged<Field>(Ptr + 100);
    }

    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public short PropertiesSize
    {
        get => MarshalUtil.ToManaged<short>(Ptr + 120);
    }

    public IEnumerable<Field> EnumerateFields()
    {
        for (var fieldLink = Children; fieldLink != null; fieldLink = fieldLink.Next)
        {
            yield return fieldLink;
        }
    }

    /// <summary>
    /// Enumerates all objects in this struct's super chain.
    /// </summary>
    public IEnumerable<Struct> EnumerateSupersAndSelf()
    {
        for (var super = this; super != null; super = super.SuperStruct)
        {
            yield return super;
        }
    }
}
