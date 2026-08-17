using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000081")]
	[Preserve]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonSerializerInternalReader _reader;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		private readonly JsonISerializableContract _contract;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x20")]
		private readonly JsonProperty _member;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xD1487C", Offset = "0xD1487C", VA = "0xD1487C")]
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
		}

		[Token(Token = "0x60003A1")]
		private T GetTokenValue<T>(object value)
		{
			return (T)null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD1491C", Offset = "0xD1491C", VA = "0xD1491C", Slot = "4")]
		public object Convert(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD14A38", Offset = "0xD14A38", VA = "0xD14A38", Slot = "5")]
		public bool ToBoolean(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xD14A98", Offset = "0xD14A98", VA = "0xD14A98", Slot = "6")]
		public int ToInt32(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xD14AF8", Offset = "0xD14AF8", VA = "0xD14AF8", Slot = "7")]
		public long ToInt64(object value)
		{
			return default(long);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xD14B58", Offset = "0xD14B58", VA = "0xD14B58", Slot = "8")]
		public float ToSingle(object value)
		{
			return default(float);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD14BB8", Offset = "0xD14BB8", VA = "0xD14BB8", Slot = "9")]
		public string ToString(object value)
		{
			return null;
		}
	}
}
