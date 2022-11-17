using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FB")]
	[Preserve]
	public class BsonObjectIdConverter : JsonConverter
	{
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xD3B764", Offset = "0xD3B764", VA = "0xD3B764", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xD3B8BC", Offset = "0xD3B8BC", VA = "0xD3B8BC", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xD3BAA0", Offset = "0xD3BAA0", VA = "0xD3BAA0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xD3BB20", Offset = "0xD3BB20", VA = "0xD3BB20")]
		public BsonObjectIdConverter()
		{
		}
	}
}
