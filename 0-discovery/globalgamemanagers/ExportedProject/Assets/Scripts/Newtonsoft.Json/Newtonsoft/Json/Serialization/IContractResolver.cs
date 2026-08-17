using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000096")]
	[Preserve]
	public interface IContractResolver
	{
		[Token(Token = "0x600041D")]
		JsonContract ResolveContract(Type type);
	}
}
