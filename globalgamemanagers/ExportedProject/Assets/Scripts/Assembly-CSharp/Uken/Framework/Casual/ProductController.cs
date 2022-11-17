using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200052E")]
	public interface ProductController
	{
		[Token(Token = "0x600279E")]
		Product Get(string productReference);

		[Token(Token = "0x600279F")]
		List<Product> Get(List<string> productReferences);
	}
}
