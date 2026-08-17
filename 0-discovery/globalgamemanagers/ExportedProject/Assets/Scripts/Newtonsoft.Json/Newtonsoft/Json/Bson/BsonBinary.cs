using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000121")]
	[Preserve]
	internal class BsonBinary : BsonValue
	{
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x29")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FE18", Offset = "0x80FE18")]
		private BsonBinaryType _003CBinaryType_003Ek__BackingField;

		[Token(Token = "0x170001D1")]
		public BsonBinaryType BinaryType
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xD353A8", Offset = "0xD353A8", VA = "0xD353A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811814", Offset = "0x811814")]
			get
			{
				return default(BsonBinaryType);
			}
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0xD353B0", Offset = "0xD353B0", VA = "0xD353B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811824", Offset = "0x811824")]
			set
			{
			}
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xD353B8", Offset = "0xD353B8", VA = "0xD353B8")]
		public BsonBinary(byte[] value, BsonBinaryType binaryType)
		{
		}
	}
}
