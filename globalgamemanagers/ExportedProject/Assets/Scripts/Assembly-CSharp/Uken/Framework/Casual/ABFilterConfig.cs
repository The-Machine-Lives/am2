using System;
using Il2CppDummyDll;
using Uken.Library.Jingot;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x200050B")]
	[AttributeAttribute(Name = "JsonConverterAttribute", RVA = "0x81FE04", Offset = "0x81FE04")]
	public class ABFilterConfig
	{
		[Token(Token = "0x40017B7")]
		[FieldOffset(Offset = "0x10")]
		public ABFilterFunctions function;

		[Token(Token = "0x40017B8")]
		[FieldOffset(Offset = "0x18")]
		public string curry;

		[Token(Token = "0x6002691")]
		[Address(RVA = "0xA1EAB4", Offset = "0xA1EAB4", VA = "0xA1EAB4")]
		public ABFilterConfig()
		{
		}
	}
}
