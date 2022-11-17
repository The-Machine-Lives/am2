using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200004D")]
	[Preserve]
	internal delegate TResult MethodCall<T, TResult>(T target, params object[] args);
}
