using BmSDK.Framework;

namespace BmSDK;

public partial class Struct
{
    /// <summary>
    /// Property: Children
    /// </summary>
    public Struct SuperStruct
    {
        get => MarshalUtil.ToManaged<Struct>(Ptr + 56);
    }

    /// <summary>
    /// Property: Children
    /// </summary>
    public Field Children
    {
        get => MarshalUtil.ToManaged<Field>(Ptr + 60);
    }

    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public short PropertiesSize
    {
        get => MarshalUtil.ToManaged<short>(Ptr + 64);
    }

    public IEnumerable<Field> EnumerateFields()
    {
        for (Field fieldLink = Children; fieldLink != null; fieldLink = fieldLink.Next)
        {
            yield return fieldLink;
        }
    }

    /// <summary>
    /// Enumerates all objects in this struct's super chain.
    /// </summary>
    public IEnumerable<Struct> EnumerateSupersAndSelf()
    {
        var super = this;
        while (super is not null)
        {
            yield return super;
            super = super.SuperStruct;
        }
    }
}
