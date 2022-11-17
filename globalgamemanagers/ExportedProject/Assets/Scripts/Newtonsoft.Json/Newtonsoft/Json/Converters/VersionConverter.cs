using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FF")]
	[Preserve]
	public class VersionConverter : JsonConverter
	{
		[Token(Token = "0x6000805")]
		[Address(RVA = "0xD3F918", Offset = "0xD3F918", VA = "0xD3F918", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xD3FA1C", Offset = "0xD3FA1C", VA = "0xD3FA1C", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xD3FD10", Offset = "0xD3FD10", VA = "0xD3FD10", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xD3FD90", Offset = "0xD3FD90", VA = "0xD3FD90")]
		public VersionConverter()
		{
		}
	}
}
