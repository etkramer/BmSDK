using System;
using System.Collections.Generic;
using System.Linq;
using UELib.Annotations;
using UELib.Branch;

namespace UELib.Core
{
    /// <summary>
    /// Represents a unreal field.
    /// </summary>
    public partial class UField : UObject
    {
        #region Serialized Members

        [CanBeNull] public UStruct Super { get; set; }
        [CanBeNull] public UField NextField { get; set; }

        public string OriginalPackageName => EnumerateOuter().OfType<UPackage>().FirstOrDefault()?.Name ?? Package.PackageName;

        public string ManagedName
        {
            get
            {
                // C# disallows fields sharing the same name as their parent class.
                if (Name == Outer?.Name)
                {
                    return $"_{Name}";
                }

                // Preserve names throughout the full inheritance chain.
                if (this.Super is not null)
                {
                    var hiddenField = (this.Outer as UClass)?
                        .EnumerateSuper()
                        .SelectMany(outer => (outer as UStruct)?.EnumerateFields())
                        .FirstOrDefault(field => field.Name == Name);

                    if (hiddenField is not null)
                    {
                        return hiddenField.ManagedName;
                    }
                }

                // Avoid name conflicts with System.Object
                if (GetPath() == "Object")
                {
                    return "GameObject";
                }
                else if (this is UClass classObj && classObj.IsClassInterface())
                {
                    // Prepend interfaces with I
                    return $"I{Name}";
                }
                else
                {
                    // Prepend structs with F
                    return this is UStruct && this is not UClass && this is not UFunction ? $"F{Name}" : Name;
                }
            }
        }

        public string ShortPath => this is UClass ? $"{OriginalPackageName}.{Name}" : GetPath();

        #endregion

        /// <summary>
        /// Initialized by the UMetaData object,
        /// This Meta contains comments and other meta related info that belongs to this instance.
        /// </summary>
        [CanBeNull] public UMetaData.UFieldData MetaData;

        #region Constructors

        protected override void Deserialize()
        {
            base.Deserialize();

            if (_Buffer.Version < (uint)PackageObjectLegacyVersion.SuperReferenceMovedToUStruct)
            {
                Super = _Buffer.ReadObject<UStruct>();
                Record(nameof(Super), Super);
            }

            NextField = _Buffer.ReadObject<UField>();
            Record(nameof(NextField), NextField);
        }

        #endregion
        
        public IEnumerable<UStruct> EnumerateSuper()
        {
            for (var super = Super; super != null; super = super.Super)
            {
                yield return super;
            }
        }

        public IEnumerable<UStruct> EnumerateSuper(UStruct super)
        {
            for (; super != null; super = super.Super)
            {
                yield return super;
            }
        }

        public IEnumerable<UField> EnumerateNext()
        {
            for (var next = NextField; next != null; next = next.NextField)
            {
                yield return next;
            }
        }

        public bool Extends(string classType)
        {
            for (var field = Super; field != null; field = field.Super)
            {
                if (string.Equals(field.Name, classType, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        [Obsolete]
        public string GetSuperGroup()
        {
            var group = string.Empty;
            for (var field = Super; field != null; field = field.Super)
            {
                group = $"{field.Name}.{@group}";
            }

            return group + Name;
        }
    }
}
