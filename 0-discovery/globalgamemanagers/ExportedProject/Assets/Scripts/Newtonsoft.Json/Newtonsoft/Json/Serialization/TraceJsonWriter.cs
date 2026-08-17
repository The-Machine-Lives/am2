using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000080")]
	[Preserve]
	internal class TraceJsonWriter : JsonWriter
	{
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x60")]
		private readonly JsonWriter _innerWriter;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x68")]
		private readonly JsonTextWriter _textWriter;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x70")]
		private readonly StringWriter _sw;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xF07DA8", Offset = "0xF07DA8", VA = "0xF07DA8")]
		public TraceJsonWriter(JsonWriter innerWriter)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xF08030", Offset = "0xF08030", VA = "0xF08030")]
		public string GetSerializedJsonMessage()
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xF08064", Offset = "0xF08064", VA = "0xF08064", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xF080F8", Offset = "0xF080F8", VA = "0xF080F8", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xF08180", Offset = "0xF08180", VA = "0xF08180", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xF08204", Offset = "0xF08204", VA = "0xF08204", Slot = "53")]
		public override void WriteValue(byte? value)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xF0828C", Offset = "0xF0828C", VA = "0xF0828C", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xF08310", Offset = "0xF08310", VA = "0xF08310", Slot = "60")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xF08394", Offset = "0xF08394", VA = "0xF08394", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xF08418", Offset = "0xF08418", VA = "0xF08418", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xF084AC", Offset = "0xF084AC", VA = "0xF084AC", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xF08530", Offset = "0xF08530", VA = "0xF08530", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xF0859C", Offset = "0xF0859C", VA = "0xF0859C", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xF08608", Offset = "0xF08608", VA = "0xF08608", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xF0868C", Offset = "0xF0868C", VA = "0xF0868C", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xF08720", Offset = "0xF08720", VA = "0xF08720", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xF087A4", Offset = "0xF087A4", VA = "0xF087A4", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xF08828", Offset = "0xF08828", VA = "0xF08828", Slot = "62")]
		public override void WriteValue(object value)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xF088AC", Offset = "0xF088AC", VA = "0xF088AC", Slot = "37")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xF08930", Offset = "0xF08930", VA = "0xF08930", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xF089B4", Offset = "0xF089B4", VA = "0xF089B4", Slot = "25")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xF08A38", Offset = "0xF08A38", VA = "0xF08A38", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xF08ABC", Offset = "0xF08ABC", VA = "0xF08ABC", Slot = "27")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xF08B40", Offset = "0xF08B40", VA = "0xF08B40", Slot = "29")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xF08BC4", Offset = "0xF08BC4", VA = "0xF08BC4", Slot = "61")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xF08C48", Offset = "0xF08C48", VA = "0xF08C48", Slot = "34")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xF08CCC", Offset = "0xF08CCC", VA = "0xF08CCC", Slot = "63")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xF08D50", Offset = "0xF08D50", VA = "0xF08D50", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xF08DB4", Offset = "0xF08DB4", VA = "0xF08DB4", Slot = "10")]
		public override void WriteEndArray()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xF08E18", Offset = "0xF08E18", VA = "0xF08E18", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xF08E94", Offset = "0xF08E94", VA = "0xF08E94", Slot = "12")]
		public override void WriteEndConstructor()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xF08EF8", Offset = "0xF08EF8", VA = "0xF08EF8", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xF08F74", Offset = "0xF08F74", VA = "0xF08F74", Slot = "14")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xF09008", Offset = "0xF09008", VA = "0xF09008", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xF0906C", Offset = "0xF0906C", VA = "0xF0906C", Slot = "8")]
		public override void WriteEndObject()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xF090D0", Offset = "0xF090D0", VA = "0xF090D0", Slot = "24")]
		public override void WriteRawValue(string json)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xF09154", Offset = "0xF09154", VA = "0xF09154", Slot = "23")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xF091D8", Offset = "0xF091D8", VA = "0xF091D8", Slot = "6")]
		public override void Close()
		{
		}
	}
}
