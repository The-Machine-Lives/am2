using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001E")]
	[Preserve]
	public interface IJsonLineInfo
	{
		[Token(Token = "0x17000004")]
		int LineNumber
		{
			[Token(Token = "0x6000026")]
			get;
		}

		[Token(Token = "0x17000005")]
		int LinePosition
		{
			[Token(Token = "0x6000027")]
			get;
		}

		[Token(Token = "0x6000025")]
		bool HasLineInfo();
	}
}
