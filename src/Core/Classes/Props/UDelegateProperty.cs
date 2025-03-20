﻿using UELib.Branch;
using UELib.Types;

namespace UELib.Core
{
    /// <summary>
    /// Delegate Property
    ///
    /// UE2+
    /// </summary>
    [UnrealRegisterClass]
    public class UDelegateProperty : UProperty
    {
        #region Serialized Members

        public UFunction Function;
        public UFunction Delegate;

        #endregion

        /// <summary>
        /// Creates a new instance of the UELib.Core.UDelegateProperty class.
        /// </summary>
        public UDelegateProperty()
        {
            Type = PropertyType.DelegateProperty;
        }

        protected override void Deserialize()
        {
            base.Deserialize();

            Function = _Buffer.ReadObject<UFunction>();
            Record(nameof(Function), Function);
            if (_Buffer.Version < (uint)PackageObjectLegacyVersion.AddedDelegateSourceToUDelegateProperty)
            {
                return;
            }

            if (_Buffer.Version < (uint)PackageObjectLegacyVersion.ChangedDelegateSourceFromNameToObject)
            {
                var source = _Buffer.ReadNameReference();
                Record(nameof(source), source);
            }
            else
            {
                Delegate = _Buffer.ReadObject<UFunction>();
                Record(nameof(Delegate), Delegate);
            }
        }

        /// <inheritdoc/>
        public override string GetFriendlyType()
        {
            return $"delegate<{GetFriendlyInnerType()}>";
        }

        public override string GetFriendlyInnerType()
        {
            return Function != null ? Function.GetFriendlyType() : "@NULL";
        }
    }
}
