using System;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Serializable]
	[Token(Token = "0x200050A")]
	public class ABGroupConfig
	{
		[Token(Token = "0x40017B4")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40017B5")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x82FE98", Offset = "0x82FE98")]
		public bool is_default;

		[Token(Token = "0x40017B6")]
		[FieldOffset(Offset = "0x1C")]
		public int weight;

		[Token(Token = "0x6002690")]
		[Address(RVA = "0xA1EABC", Offset = "0xA1EABC", VA = "0xA1EABC")]
		public ABGroupConfig()
		{
		}
	}
}
