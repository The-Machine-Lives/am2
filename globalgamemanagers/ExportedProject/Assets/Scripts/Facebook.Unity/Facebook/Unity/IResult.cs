using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000040")]
	public interface IResult
	{
		[Token(Token = "0x1700004E")]
		string Error
		{
			[Token(Token = "0x6000131")]
			get;
		}

		[Token(Token = "0x1700004F")]
		IDictionary<string, object> ResultDictionary
		{
			[Token(Token = "0x6000132")]
			get;
		}

		[Token(Token = "0x17000050")]
		string RawResult
		{
			[Token(Token = "0x6000133")]
			get;
		}

		[Token(Token = "0x17000051")]
		bool Cancelled
		{
			[Token(Token = "0x6000134")]
			get;
		}
	}
}
