using System;
using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Serializable]
	[Token(Token = "0x2000457")]
	public class InventoryRevision
	{
		[Token(Token = "0x4001409")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400140A")]
		[FieldOffset(Offset = "0x18")]
		public string item_reference;

		[Token(Token = "0x400140B")]
		[FieldOffset(Offset = "0x20")]
		public string attribute;

		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x28")]
		public object value;

		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x30")]
		public int? upper_bound;

		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x38")]
		public int? lower_bound;

		[Token(Token = "0x400140F")]
		[FieldOffset(Offset = "0x40")]
		public int reason;

		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0xBA5CC4", Offset = "0xBA5CC4", VA = "0xBA5CC4")]
		public InventoryRevision()
		{
		}
	}
}
