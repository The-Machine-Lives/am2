using System;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F5")]
	[AttributeAttribute(Name = "GroupAttribute", RVA = "0x81FD5C", Offset = "0x81FD5C")]
	public class RDTimeSlot : BaseEntityDocument
	{
		[Token(Token = "0x400177C")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FBF0", Offset = "0x82FBF0")]
		public DateTime startDate;

		[Token(Token = "0x400177D")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x82FC28", Offset = "0x82FC28")]
		public DateTime endDate;

		[Token(Token = "0x6002638")]
		[Address(RVA = "0xA81C28", Offset = "0xA81C28", VA = "0xA81C28")]
		public RDTimeSlot()
		{
		}
	}
}
