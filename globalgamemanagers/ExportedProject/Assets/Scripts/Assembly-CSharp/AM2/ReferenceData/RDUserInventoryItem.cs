using System;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003BC")]
	[AttributeAttribute(Name = "GroupAttribute", RVA = "0x81F988", Offset = "0x81F988")]
	public class RDUserInventoryItem : BaseEntityDocument
	{
		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0x30")]
		public string item_type;

		[Token(Token = "0x40011DB")]
		[FieldOffset(Offset = "0x38")]
		public DateTime expires_at;

		[Token(Token = "0x40011DC")]
		[FieldOffset(Offset = "0x40")]
		public int? min_quantity;

		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x82E1C0", Offset = "0x82E1C0")]
		public int? max_quantity;

		[Token(Token = "0x40011DE")]
		[FieldOffset(Offset = "0x50")]
		public double last_claimed_at;

		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0x9BABF4", Offset = "0x9BABF4", VA = "0x9BABF4")]
		public RDUserInventoryItem()
		{
		}

		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x9BABFC", Offset = "0x9BABFC", VA = "0x9BABFC")]
		public RDUserInventoryItem(string _refName)
		{
		}
	}
}
