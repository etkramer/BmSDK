using UELib.Types;

namespace UELib.Core
{
    /// <summary>
    /// Bool Property
    /// </summary>
    [UnrealRegisterClass]
    public class UBoolProperty : UProperty
    {
        public int BitfieldIdx { get; internal set; }

        /// <summary>
        ///	Creates a new instance of the UELib.Core.UBoolProperty class.
        /// </summary>
        public UBoolProperty()
        {
            Type = PropertyType.BoolProperty;
        }

        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            return "bool";
        }
    }
}