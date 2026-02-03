using System.Reflection;

namespace BmSDK.Framework.Redirection;

record GlobalRedirectorInfo(Type TargetClass, MethodInfo RedirectMethod, object? RedirectTarget);
