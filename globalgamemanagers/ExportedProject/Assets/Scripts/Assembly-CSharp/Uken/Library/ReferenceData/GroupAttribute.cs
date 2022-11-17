using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000479")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x81FB44", Offset = "0x81FB44")]
	public class GroupAttribute : Attribute
	{
		[Token(Token = "0x4001497")]
		[FieldOffset(Offset = "0x10")]
		public string groupName;

		[Token(Token = "0x6002119")]
		[Address(RVA = "0xB37C90", Offset = "0xB37C90", VA = "0xB37C90")]
		public GroupAttribute(string _groupName)
		{
		}
	}
}
