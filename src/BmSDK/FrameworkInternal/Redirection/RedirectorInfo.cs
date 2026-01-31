using System.Reflection;

namespace BmSDK.Framework.Redirection;

record RedirectorInfo(Class TargetClass, MethodInfo RedirectMethod, object? RedirectTarget);
