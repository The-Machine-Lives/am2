using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F9")]
	public class HashSetConverter : JsonConverter
	{
		[Token(Token = "0x1700016D")]
		public override bool CanWrite
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xD3BFA8", Offset = "0xD3BFA8", VA = "0xD3BFA8", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xD3BC68", Offset = "0xD3BC68", VA = "0xD3BC68", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xD3BC6C", Offset = "0xD3BC6C", VA = "0xD3BC6C", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xD3BEE8", Offset = "0xD3BEE8", VA = "0xD3BEE8", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xD3BFB0", Offset = "0xD3BFB0", VA = "0xD3BFB0")]
		public HashSetConverter()
		{
		}
	}
}
