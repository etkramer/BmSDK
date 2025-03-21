using UELib.Types;

namespace UELib.Core
{
    /// <summary>
    /// Float Property
    /// </summary>
    [UnrealRegisterClass]
    public class UFloatProperty : UProperty
    {
        /// <summary>
        ///	Creates a new instance of the UELib.Core.UFloatProperty class.
        /// </summary>
        public UFloatProperty()
        {
            Type = PropertyType.FloatProperty;
        }

        protected override void Deserialize()
        {
            base.Deserialize();
            ElementSize = sizeof(int);
        }

        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            return "float";
        }
    }
}