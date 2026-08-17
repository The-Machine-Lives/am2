using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000023")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x80E2BC", Offset = "0x80E2BC")]
	[Preserve]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x34")]
		private MemberSerialization _memberSerialization;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x38")]
		internal Required? _itemRequired;

		[Token(Token = "0x1700000A")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xD4D728", Offset = "0xD4D728", VA = "0xD4D728")]
			get
			{
				return default(MemberSerialization);
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xD4D730", Offset = "0xD4D730", VA = "0xD4D730")]
		public JsonObjectAttribute()
		{
		}
	}
}
