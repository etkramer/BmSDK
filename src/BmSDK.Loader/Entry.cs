using BmSDK;

using System.Diagnostics;

namespace BmSDK.Loader;

static class Entry
{
    delegate int DllMainDelegate();

    public static int DllMain()
    {
        var obj = null as UObject;
        // Debug.WriteLine(obj.Name);

        Debug.WriteLine("Hello from BmSDK.Loader 2!");
        return 0;
    }
}
