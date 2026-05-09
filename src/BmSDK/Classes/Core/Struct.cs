using BmSDK.Framework;

namespace BmSDK;

public partial class Struct
{
    /// <summary>
    /// Property: Children
    /// </summary>
    public Struct SuperStruct => MarshalUtil.ToManaged<Struct>(Ptr + 56);

    /// <summary>
    /// Property: Children
    /// </summary>
    public Field Children => MarshalUtil.ToManaged<Field>(Ptr + 60);

    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public short PropertiesSize => MarshalUtil.ToManaged<short>(Ptr + 64);

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
