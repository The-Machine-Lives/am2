using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000122")]
	[Preserve]
	internal class BsonRegex : BsonToken
	{
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FE28", Offset = "0x80FE28")]
		private BsonString _003CPattern_003Ek__BackingField;

		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FE38", Offset = "0x80FE38")]
		private BsonString _003COptions_003Ek__BackingField;

		[Token(Token = "0x170001D2")]
		public BsonString Pattern
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0xD3746C", Offset = "0xD3746C", VA = "0xD3746C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811834", Offset = "0x811834")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000900")]
			[Address(RVA = "0xD396F4", Offset = "0xD396F4", VA = "0xD396F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811844", Offset = "0x811844")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public BsonString Options
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0xD37474", Offset = "0xD37474", VA = "0xD37474")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811854", Offset = "0x811854")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000902")]
			[Address(RVA = "0xD396FC", Offset = "0xD396FC", VA = "0xD396FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811864", Offset = "0x811864")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public override BsonType Type
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0xD397BC", Offset = "0xD397BC", VA = "0xD397BC", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xD39704", Offset = "0xD39704", VA = "0xD39704")]
		public BsonRegex(string pattern, string options)
		{
		}
	}
}
