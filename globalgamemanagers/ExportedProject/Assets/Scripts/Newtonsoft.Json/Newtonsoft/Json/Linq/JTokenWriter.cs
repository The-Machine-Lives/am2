using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D4")]
	[Preserve]
	public class JTokenWriter : JsonWriter
	{
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x60")]
		private JContainer _token;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x68")]
		private JContainer _parent;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x70")]
		private JValue _value;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x78")]
		private JToken _current;

		[Token(Token = "0x1700012E")]
		public JToken Token
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xCFE7C8", Offset = "0xCFE7C8", VA = "0xCFE7C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xCFE7E0", Offset = "0xCFE7E0", VA = "0xCFE7E0")]
		public JTokenWriter()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xCFE848", Offset = "0xCFE848", VA = "0xCFE848", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xCFE850", Offset = "0xCFE850", VA = "0xCFE850", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xCFE8DC", Offset = "0xCFE8DC", VA = "0xCFE8DC")]
		private void AddParent(JContainer container)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xCFE920", Offset = "0xCFE920", VA = "0xCFE920")]
		private void RemoveParent()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xCFE998", Offset = "0xCFE998", VA = "0xCFE998", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xCFEA24", Offset = "0xCFEA24", VA = "0xCFEA24", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xCFEAC4", Offset = "0xCFEAC4", VA = "0xCFEAC4", Slot = "17")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xCFEAC8", Offset = "0xCFEAC8", VA = "0xCFEAC8", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xCFEBAC", Offset = "0xCFEBAC", VA = "0xCFEBAC")]
		private void AddValue(object value, JsonToken token)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xCFEC64", Offset = "0xCFEC64", VA = "0xCFEC64")]
		internal void AddValue(JValue value, JsonToken token)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xCFED7C", Offset = "0xCFED7C", VA = "0xCFED7C", Slot = "62")]
		public override void WriteValue(object value)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xCFED84", Offset = "0xCFED84", VA = "0xCFED84", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xCFEDB0", Offset = "0xCFEDB0", VA = "0xCFEDB0", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xCFEDDC", Offset = "0xCFEDDC", VA = "0xCFEDDC", Slot = "23")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xCFEE60", Offset = "0xCFEE60", VA = "0xCFEE60", Slot = "63")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xCFEEFC", Offset = "0xCFEEFC", VA = "0xCFEEFC", Slot = "25")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xCFEF30", Offset = "0xCFEF30", VA = "0xCFEF30", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xCFEFB4", Offset = "0xCFEFB4", VA = "0xCFEFB4", Slot = "27")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810EF0", Offset = "0x810EF0")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xCFF038", Offset = "0xCFF038", VA = "0xCFF038", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xCFF0BC", Offset = "0xCFF0BC", VA = "0xCFF0BC", Slot = "29")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810F04", Offset = "0x810F04")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xCFF140", Offset = "0xCFF140", VA = "0xCFF140", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xCFF1C4", Offset = "0xCFF1C4", VA = "0xCFF1C4", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xCFF248", Offset = "0xCFF248", VA = "0xCFF248", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xCFF2CC", Offset = "0xCFF2CC", VA = "0xCFF2CC", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xCFF350", Offset = "0xCFF350", VA = "0xCFF350", Slot = "34")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810F18", Offset = "0x810F18")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xCFF3D4", Offset = "0xCFF3D4", VA = "0xCFF3D4", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xCFF47C", Offset = "0xCFF47C", VA = "0xCFF47C", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xCFF500", Offset = "0xCFF500", VA = "0xCFF500", Slot = "37")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810F2C", Offset = "0x810F2C")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xCFF584", Offset = "0xCFF584", VA = "0xCFF584", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xCFF618", Offset = "0xCFF618", VA = "0xCFF618", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xCFF6E4", Offset = "0xCFF6E4", VA = "0xCFF6E4", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xCFF778", Offset = "0xCFF778", VA = "0xCFF778", Slot = "60")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xCFF7AC", Offset = "0xCFF7AC", VA = "0xCFF7AC", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xCFF830", Offset = "0xCFF830", VA = "0xCFF830", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xCFF8C4", Offset = "0xCFF8C4", VA = "0xCFF8C4", Slot = "61")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xCFF8F8", Offset = "0xCFF8F8", VA = "0xCFF8F8", Slot = "16")]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}
	}
}
