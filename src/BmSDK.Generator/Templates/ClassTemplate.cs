using BmSDK.Generator.Utils;
using UELib.Core;
using UELib.Flags;

namespace BmSDK.Generator.Templates;

static class ClassTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        var propFields = classObj.EnumerateFields().OfType<UProperty>().ToArray();
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();

        // Ignore private functions
        var funcFields = classObj
            .EnumerateFields()
            .OfType<UFunction>()
            .Where(func => !func.HasFunctionFlag(FunctionFlags.Private))
            .ToArray();

        // Get super class decl
        var classDeclSuper = classObj.Super is null
            ? ""
            : $" : {TypeMapper.GetManagedPathForType(classObj.Super, classObj)}, IStaticObject";

        // Make ctor for constructing from an object pointer
        var ctorText = $"protected {classObj.ManagedName}(IntPtr ptr)";
        ctorText += classObj.GetPath() == "Object" ? " { Ptr = ptr; }" : " : base(ptr) { }";

        // Format flags
        var flagsText = $"({FlagUtils.DropUnknownBits((ClassFlags)classObj.ClassFlags)})";

        // Format layout info
        var layoutInfoText =
            $"(size = 0x{classObj.StructSize:X}, offset = 0x{classObj.StructStartOffset:X})";

        return $$"""
            /// <summary>
            /// Class: {{classObj.GetPath()}} {{flagsText}}<br/>
            /// {{layoutInfoText}}
            /// </summary>
            public partial class {{classObj.ManagedName}}{{classDeclSuper}}
            {
                public static Class StaticClass() => _staticClass ??= StaticFindObjectChecked<Class>(null, null, "{{classObj.ShortPath}}", false);
                static Class _staticClass = null;

                internal {{classObj.ManagedName}}() { }

                {{RenderMainConstructor(classObj)}}
                /// <summary>
                /// Constructs a new wrapper instance from the given object pointer.
                /// </summary>
                {{ctorText}}

                {{propFields.Select(PropTemplate.Render)}}

                {{funcFields.Select(FuncTemplate.Render)}}

                {{enumFields.Select(EnumTemplate.Render)}}

                {{structFields.Select(StructTemplate.Render)}}
            }
            """;
    }

    static FormattableString RenderMainConstructor(UClass classObj)
    {
        // No main/public constructor for abstract classes
        if (classObj.HasClassFlag(ClassFlags.Abstract))
        {
            return $"";
        }

        return $$"""
            /// <summary>
            /// Constructs a new {{classObj.ManagedName}}.
            /// </summary>
            public {{classObj.ManagedName}}(
                GameObject Outer = null,
                string Name = null,
                EObjectFlags SetFlags = 0,
                {{classObj.ManagedName}} Template = null
            )
                : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }
            
            """;
    }
}
