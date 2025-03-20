﻿namespace UELib.Core
{
    /// <summary>
    /// Represents a unreal const.
    /// </summary>
    [UnrealRegisterClass]
    public partial class UConst : UField
    {
        #region Serialized Members

        /// <summary>
        /// Constant Value
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Constructors

        protected override void Deserialize()
        {
            base.Deserialize();
            
            Value = _Buffer.ReadString();
            Record(nameof(Value), Value);
        }

        #endregion
    }
}
