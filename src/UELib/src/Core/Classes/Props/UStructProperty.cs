using System;
using System.Linq;
using Spectre.Console;
using UELib.Types;

namespace UELib.Core
{
    /// <summary>
    /// Struct Property
    /// </summary>
    [UnrealRegisterClass]
    public class UStructProperty : UProperty
    {
        #region Serialized Members

        public UStruct Struct;

        #endregion

        /// <summary>
        /// Creates a new instance of the UELib.Core.UStructProperty class.
        /// </summary>
        public UStructProperty()
        {
            Type = PropertyType.StructProperty;
        }

        protected override void Deserialize()
        {
            base.Deserialize();

            Struct = _Buffer.ReadObject<UStruct>();
            Record(nameof(Struct), Struct);

            ElementSize = (ushort)Struct.StructSize;
            Alignment = 4;
            foreach (var prop in Struct.EnumerateFields().OfType<UProperty>())
            {
                Alignment = Math.Max(Alignment, prop.Alignment);
            }

            // Special alignment rules for FMatrix
            if (Struct.Name == "Matrix")
            {
                Alignment = 16;
            }
        }

        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            return Struct != null ? Struct.GetFriendlyType() : "@NULL";
        }
    }
}
