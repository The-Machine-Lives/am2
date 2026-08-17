using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000120")]
	[Preserve]
	internal class BsonString : BsonValue
	{
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FDF8", Offset = "0x80FDF8")]
		private int _003CByteCount_003Ek__BackingField;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FE08", Offset = "0x80FE08")]
		private bool _003CIncludeLength_003Ek__BackingField;

		[Token(Token = "0x170001CF")]
		public int ByteCount
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xD3737C", Offset = "0xD3737C", VA = "0xD3737C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8117D4", Offset = "0x8117D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xD3764C", Offset = "0xD3764C", VA = "0xD3764C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8117E4", Offset = "0x8117E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public bool IncludeLength
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xD37654", Offset = "0xD37654", VA = "0xD37654")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8117F4", Offset = "0x8117F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xD397C4", Offset = "0xD397C4", VA = "0xD397C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811804", Offset = "0x811804")]
			set
			{
			}
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xD377D4", Offset = "0xD377D4", VA = "0xD377D4")]
		public BsonString(object value, bool includeLength)
		{
		}
	}
}
