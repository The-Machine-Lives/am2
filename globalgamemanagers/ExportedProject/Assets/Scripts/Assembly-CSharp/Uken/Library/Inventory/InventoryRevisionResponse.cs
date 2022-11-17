using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Serializable]
	[Token(Token = "0x2000458")]
	public class InventoryRevisionResponse
	{
		[Token(Token = "0x4001410")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0x18")]
		public List<InventoryRevision> revisions;

		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0xBA5CCC", Offset = "0xBA5CCC", VA = "0xBA5CCC")]
		public InventoryRevisionResponse()
		{
		}
	}
}
