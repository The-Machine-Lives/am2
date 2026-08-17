using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200011F")]
	[Preserve]
	internal class BsonValue : BsonToken
	{
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x20")]
		private readonly object _value;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x28")]
		private readonly BsonType _type;

		[Token(Token = "0x170001CD")]
		public object Value
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xD37374", Offset = "0xD37374", VA = "0xD37374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CE")]
		public override BsonType Type
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xD397D8", Offset = "0xD397D8", VA = "0xD397D8", Slot = "4")]
			get
			{
				return default(BsonType);
			}
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xD353FC", Offset = "0xD353FC", VA = "0xD353FC")]
		public BsonValue(object value, BsonType type)
		{
		}
	}
}
