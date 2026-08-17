using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200002C")]
	[Preserve]
	public class JsonTextWriter : JsonWriter
	{
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x60")]
		private readonly TextWriter _writer;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x68")]
		private Base64Encoder _base64Encoder;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x70")]
		private char _indentChar;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x74")]
		private int _indentation;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x78")]
		private char _quoteChar;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x7A")]
		private bool _quoteName;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x80")]
		private bool[] _charEscapeFlags;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x88")]
		private char[] _writeBuffer;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x90")]
		private IArrayPool<char> _arrayPool;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x98")]
		private char[] _indentChars;

		[Token(Token = "0x17000024")]
		private Base64Encoder Base64Encoder
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xFE3398", Offset = "0xFE3398", VA = "0xFE3398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public char QuoteChar
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xFE3414", Offset = "0xFE3414", VA = "0xFE3414")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xFE341C", Offset = "0xFE341C", VA = "0xFE341C")]
		public JsonTextWriter(TextWriter textWriter)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xFE35D0", Offset = "0xFE35D0", VA = "0xFE35D0", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xFE3638", Offset = "0xFE3638", VA = "0xFE3638", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xFE36C4", Offset = "0xFE36C4", VA = "0xFE36C4", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xFE370C", Offset = "0xFE370C", VA = "0xFE370C", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xFE37E0", Offset = "0xFE37E0", VA = "0xFE37E0", Slot = "17")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xFE393C", Offset = "0xFE393C", VA = "0xFE393C", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xFE3A8C", Offset = "0xFE3A8C", VA = "0xFE3A8C", Slot = "14")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xFE3B98", Offset = "0xFE3B98", VA = "0xFE3B98", Slot = "5")]
		internal override void OnStringEscapeHandlingChanged()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xFE354C", Offset = "0xFE354C", VA = "0xFE354C")]
		private void UpdateCharEscapeFlags()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xFE3BA4", Offset = "0xFE3BA4", VA = "0xFE3BA4", Slot = "18")]
		protected override void WriteIndent()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xFE3D40", Offset = "0xFE3D40", VA = "0xFE3D40", Slot = "19")]
		protected override void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xFE3D78", Offset = "0xFE3D78", VA = "0xFE3D78", Slot = "20")]
		protected override void WriteIndentSpace()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xFE3DB0", Offset = "0xFE3DB0", VA = "0xFE3DB0")]
		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xFE3DF0", Offset = "0xFE3DF0", VA = "0xFE3DF0", Slot = "62")]
		public override void WriteValue(object value)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xFE3ED8", Offset = "0xFE3ED8", VA = "0xFE3ED8", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xFE3FA0", Offset = "0xFE3FA0", VA = "0xFE3FA0", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xFE4050", Offset = "0xFE4050", VA = "0xFE4050", Slot = "23")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xFE4094", Offset = "0xFE4094", VA = "0xFE4094", Slot = "25")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xFE39A8", Offset = "0xFE39A8", VA = "0xFE39A8")]
		private void WriteEscapedString(string value, bool quote)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xFE41A8", Offset = "0xFE41A8", VA = "0xFE41A8", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xFE4288", Offset = "0xFE4288", VA = "0xFE4288", Slot = "27")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x80FFB8", Offset = "0x80FFB8")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xFE42D0", Offset = "0xFE42D0", VA = "0xFE42D0", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xFE4318", Offset = "0xFE4318", VA = "0xFE4318", Slot = "29")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x80FFCC", Offset = "0x80FFCC")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xFE44B0", Offset = "0xFE44B0", VA = "0xFE44B0", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xFE4594", Offset = "0xFE4594", VA = "0xFE4594", Slot = "47")]
		public override void WriteValue(float? value)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xFE46C4", Offset = "0xFE46C4", VA = "0xFE46C4", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xFE47A0", Offset = "0xFE47A0", VA = "0xFE47A0", Slot = "48")]
		public override void WriteValue(double? value)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xFE48D0", Offset = "0xFE48D0", VA = "0xFE48D0", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xFE4990", Offset = "0xFE4990", VA = "0xFE4990", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xFE49D8", Offset = "0xFE49D8", VA = "0xFE49D8", Slot = "34")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x80FFE0", Offset = "0x80FFE0")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xFE4A20", Offset = "0xFE4A20", VA = "0xFE4A20", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xFE4AE0", Offset = "0xFE4AE0", VA = "0xFE4AE0", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xFE4B28", Offset = "0xFE4B28", VA = "0xFE4B28", Slot = "37")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x80FFF4", Offset = "0x80FFF4")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xFE4B70", Offset = "0xFE4B70", VA = "0xFE4B70", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xFE4C38", Offset = "0xFE4C38", VA = "0xFE4C38", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xFE4F44", Offset = "0xFE4F44", VA = "0xFE4F44", Slot = "60")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xFE5048", Offset = "0xFE5048", VA = "0xFE5048", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xFE52C4", Offset = "0xFE52C4", VA = "0xFE52C4", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xFE53F8", Offset = "0xFE53F8", VA = "0xFE53F8", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xFE54D0", Offset = "0xFE54D0", VA = "0xFE54D0", Slot = "61")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xFE55B4", Offset = "0xFE55B4", VA = "0xFE55B4", Slot = "63")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xFE4170", Offset = "0xFE4170", VA = "0xFE4170")]
		private void EnsureWriteBuffer()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xFE41F0", Offset = "0xFE41F0", VA = "0xFE41F0")]
		private void WriteIntegerValue(long value)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xFE4360", Offset = "0xFE4360", VA = "0xFE4360")]
		private void WriteIntegerValue(ulong uvalue)
		{
		}
	}
}
