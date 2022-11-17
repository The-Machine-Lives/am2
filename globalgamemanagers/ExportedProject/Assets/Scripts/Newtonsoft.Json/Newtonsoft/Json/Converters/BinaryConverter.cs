using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F6")]
	[Preserve]
	public class BinaryConverter : JsonConverter
	{
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x10")]
		private ReflectionObject _reflectionObject;

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xD3AD24", Offset = "0xD3AD24", VA = "0xD3AD24", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xD3AD98", Offset = "0xD3AD98", VA = "0xD3AD98")]
		private byte[] GetByteArray(object value)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xD3AF7C", Offset = "0xD3AF7C", VA = "0xD3AF7C")]
		private void EnsureReflectionObject(Type t)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xD3B130", Offset = "0xD3B130", VA = "0xD3B130", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xD3B4CC", Offset = "0xD3B4CC", VA = "0xD3B4CC")]
		private byte[] ReadByteArray(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xD3B700", Offset = "0xD3B700", VA = "0xD3B700", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xD3B754", Offset = "0xD3B754", VA = "0xD3B754")]
		public BinaryConverter()
		{
		}
	}
}
