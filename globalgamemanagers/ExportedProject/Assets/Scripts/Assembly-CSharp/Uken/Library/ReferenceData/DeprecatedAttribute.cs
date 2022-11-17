using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200045F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x81FB08", Offset = "0x81FB08")]
	public class DeprecatedAttribute : Attribute
	{
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x10")]
		public string message;

		[Token(Token = "0x60020AC")]
		[Address(RVA = "0xB379D0", Offset = "0xB379D0", VA = "0xB379D0")]
		public DeprecatedAttribute()
		{
		}

		[Token(Token = "0x60020AD")]
		[Address(RVA = "0xB379D8", Offset = "0xB379D8", VA = "0xB379D8")]
		public DeprecatedAttribute(string _message)
		{
		}
	}
}
