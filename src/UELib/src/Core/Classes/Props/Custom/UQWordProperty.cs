#if BIOSHOCK
namespace UELib.Core
{
    /// <summary>
    /// QWord Property
    /// </summary>
    [UnrealRegisterClass]
    public class UQWordProperty : UIntProperty
    {
        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            return "Qword";
        }

        protected override void Deserialize()
        {
            base.Deserialize();
            ElementSize = 8;
            Alignment = 8;
        }
    }
}
#endif