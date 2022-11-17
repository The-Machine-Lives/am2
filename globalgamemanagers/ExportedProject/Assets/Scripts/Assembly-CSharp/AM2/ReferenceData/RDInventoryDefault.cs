using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003BA")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F918", Offset = "0x81F918")]
	public class RDInventoryDefault : BaseEntityDocument
	{
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x30")]
		public string item_reference;

		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x38")]
		public string item_type;

		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x40")]
		public long quantity;

		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, bool> defaultBoolTraits;

		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, long> defaultLongTraits;

		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x9BA5CC", Offset = "0x9BA5CC", VA = "0x9BA5CC")]
		public RDInventoryDefault()
		{
		}

		[Token(Token = "0x6001CBD")]
		[Address(RVA = "0x9BA5D4", Offset = "0x9BA5D4", VA = "0x9BA5D4")]
		public RDInventoryDefault(string _refName)
		{
		}
	}
}
