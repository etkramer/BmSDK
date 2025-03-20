using UELib.Types;

namespace UELib.Core
{
    /// <summary>
    /// Dynamic Array Property
    /// </summary>
    [UnrealRegisterClass]
    public class UArrayProperty : UProperty
    {
        #region Serialized Members

        public UProperty InnerProperty;

        #endregion

        /// <summary>
        /// Creates a new instance of the UELib.Core.UArrayProperty class.
        /// </summary>
        public UArrayProperty()
        {
            Type = PropertyType.ArrayProperty;
        }

        protected override void Deserialize()
        {
            base.Deserialize();
            
            InnerProperty = _Buffer.ReadObject<UProperty>();
            Record(nameof(InnerProperty), InnerProperty);
        }

        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            if (InnerProperty != null)
            {
                return $"array<{GetFriendlyInnerType()}>";
            }

            return "array";
        }

        public override string GetFriendlyInnerType()
        {
            return InnerProperty != null
                ? (InnerProperty.IsClassType("ClassProperty") || InnerProperty.IsClassType("DelegateProperty"))
                    ? (" " + InnerProperty.FormatFlags() + InnerProperty.GetFriendlyType() + " ")
                    : (InnerProperty.FormatFlags() + InnerProperty.GetFriendlyType())
                : "@NULL";
        }
    }
}
