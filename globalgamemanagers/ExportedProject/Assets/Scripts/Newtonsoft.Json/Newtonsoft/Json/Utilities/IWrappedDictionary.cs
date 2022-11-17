using System.Collections;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000061")]
	[Preserve]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		[Token(Token = "0x17000070")]
		object UnderlyingDictionary
		{
			[Token(Token = "0x6000293")]
			get;
		}
	}
}
