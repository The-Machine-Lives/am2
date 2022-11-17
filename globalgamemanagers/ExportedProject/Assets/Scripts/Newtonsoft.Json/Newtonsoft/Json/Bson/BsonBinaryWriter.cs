using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000118")]
	[Preserve]
	internal class BsonBinaryWriter
	{
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding Encoding;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x10")]
		private readonly BinaryWriter _writer;

		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _largeByteBuffer;

		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FDC8", Offset = "0x80FDC8")]
		private DateTimeKind _003CDateTimeKindHandling_003Ek__BackingField;

		[Token(Token = "0x170001C6")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xD35438", Offset = "0xD35438", VA = "0xD35438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811784", Offset = "0x811784")]
			get
			{
				return default(DateTimeKind);
			}
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xD35440", Offset = "0xD35440", VA = "0xD35440")]
		public void Close()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xD35474", Offset = "0xD35474", VA = "0xD35474")]
		public void WriteToken(BsonToken t)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xD35F20", Offset = "0xD35F20", VA = "0xD35F20")]
		private void WriteTokenInternal(BsonToken t)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xD37384", Offset = "0xD37384", VA = "0xD37384")]
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xD3747C", Offset = "0xD3747C", VA = "0xD3747C")]
		public void WriteUtf8Bytes(string s, int byteCount)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xD37628", Offset = "0xD37628", VA = "0xD37628")]
		private int CalculateSize(int stringByteCount)
		{
			return default(int);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xD37630", Offset = "0xD37630", VA = "0xD37630")]
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			return default(int);
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xD354A0", Offset = "0xD354A0", VA = "0xD354A0")]
		private int CalculateSize(BsonToken t)
		{
			return default(int);
		}
	}
}
