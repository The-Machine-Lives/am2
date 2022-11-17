using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001A")]
	[Preserve]
	public enum MetadataPropertyHandling
	{
		[Token(Token = "0x400002E")]
		Default = 0,
		[Token(Token = "0x400002F")]
		ReadAhead = 1,
		[Token(Token = "0x4000030")]
		Ignore = 2
	}
}
