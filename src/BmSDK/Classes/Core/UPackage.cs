namespace BmSDK;

public partial class UPackage
{
    public static UPackage GetTransientPackage() =>
        _transientPackage ??= StaticFindObjectChecked<UPackage>(null, null, "Transient", false);

    static UPackage? _transientPackage = null;
}
