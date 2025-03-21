using UELib.Types;

namespace UELib.Core
{
    /// <summary>
    /// Dynamic String
    /// </summary>
    [UnrealRegisterClass]
    public class UStrProperty : UProperty
    {
        /// <summary>
        /// Creates a new instance of the UELib.Core.UStrProperty class.
        /// </summary>
        public UStrProperty()
        {
            Type = PropertyType.StrProperty;
        }

        protected override void Deserialize()
        {
            base.Deserialize();
            ElementSize = 12;
        }

        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            return "string";
        }
    }
}