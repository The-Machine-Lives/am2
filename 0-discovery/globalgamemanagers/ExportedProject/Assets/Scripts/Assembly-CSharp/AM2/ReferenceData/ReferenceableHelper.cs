using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200037B")]
	public class ReferenceableHelper
	{
		[Token(Token = "0x6001B99")]
		public static void AddListItemsToDict<T, Y>(List<T> listItems, ref Dictionary<string, Y> referenceableDict) where T : IReferenceable, Y
		{
		}

		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x96AF50", Offset = "0x96AF50", VA = "0x96AF50")]
		public ReferenceableHelper()
		{
		}
	}
}
