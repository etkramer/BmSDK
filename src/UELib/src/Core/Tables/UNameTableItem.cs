using System.Diagnostics;
using System.Runtime.CompilerServices;
using UELib.Branch;

namespace UELib
{
    /// <summary>
    /// A names table entry, representing all unique names within a package.
    /// </summary>
    public sealed class UNameTableItem : UTableItem, IUnrealSerializableClass
    {
        #region Serialized Members

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        internal string _Name;

        public ulong Flags
        {
            get => _Flags;
            set => _Flags = value;
        }
        internal ulong _Flags;

        public ushort NonCasePreservingHash;
        public ushort CasePreservingHash;
        
        #endregion

        public void Deserialize(IUnrealStream stream)
        {
            _Name = DeserializeName(stream);
            Debug.Assert(_Name.Length <= 1024, "Maximum name length exceeded! Possible corrupt or unsupported package.");
#if BIOSHOCK
            if (stream.Package.Build == UnrealPackage.GameBuild.BuildName.BioShock)
            {
                _Flags = stream.ReadUInt64();
                return;
            }
#endif
            _Flags = stream.Version >= (uint)PackageObjectLegacyVersion.ObjectFlagsSizeExpandedTo64Bits
                ? stream.ReadUInt64()
                : stream.ReadUInt32();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private string DeserializeName(IUnrealStream stream)
        {
#if UE1
            // Very old packages use a simple Ansi encoding.
            if (stream.Version < (uint)PackageObjectLegacyVersion.Release64) return stream.ReadAnsiNullString();
#endif
            return stream.ReadString();
        }

        public void Serialize(IUnrealStream stream)
        {
            stream.Write(_Name);
            if (stream.Version < (uint)PackageObjectLegacyVersion.ObjectFlagsSizeExpandedTo64Bits)
                // Writing UINT
                stream.Write((uint)_Flags);
            else
                // Writing ULONG
                stream.Write(_Flags);
        }

        public override string ToString()
        {
            return _Name;
        }

        public static implicit operator string(UNameTableItem a)
        {
            return a._Name;
        }

        public static implicit operator int(UNameTableItem a)
        {
            return a.Index;
        }
    }
}
