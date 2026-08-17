using System.Collections;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200005E")]
	[Preserve]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		[Token(Token = "0x17000068")]
		object UnderlyingCollection
		{
			[Token(Token = "0x6000257")]
			get;
		}
	}
}
