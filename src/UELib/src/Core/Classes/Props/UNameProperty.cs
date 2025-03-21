using UELib.Types;

namespace UELib.Core
{
    /// <summary>
    /// Name Property
    /// </summary>
    [UnrealRegisterClass]
    public class UNameProperty : UProperty
    {
        /// <summary>
        ///	Creates a new instance of the UELib.Core.UNameProperty class.
        /// </summary>
        public UNameProperty()
        {
            Type = PropertyType.NameProperty;
        }

        protected override void Deserialize()
        {
            base.Deserialize();
            ElementSize = 8;
        }

        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            return "name";
        }
    }
}