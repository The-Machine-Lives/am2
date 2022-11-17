using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000454")]
	public interface IItemModelIndexer
	{
		[Token(Token = "0x6001FF6")]
		Dictionary<string, ItemMinimalDetails> GetAllItemDetails();
	}
}
