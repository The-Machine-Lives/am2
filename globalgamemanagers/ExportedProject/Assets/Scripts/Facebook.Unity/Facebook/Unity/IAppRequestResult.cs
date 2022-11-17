using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200002D")]
	public interface IAppRequestResult : IResult
	{
		[Token(Token = "0x1700004A")]
		IEnumerable<string> To
		{
			[Token(Token = "0x600012B")]
			get;
		}
	}
}
