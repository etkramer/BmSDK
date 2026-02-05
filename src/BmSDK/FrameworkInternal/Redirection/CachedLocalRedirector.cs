using System.Reflection;

namespace BmSDK.Framework.Redirection;

record CachedLocalRedirector(Type TargetType, string FuncPath, MethodInfo Redirector);
