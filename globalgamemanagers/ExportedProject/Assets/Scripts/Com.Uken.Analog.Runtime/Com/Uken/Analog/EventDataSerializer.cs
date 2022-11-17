using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000031")]
	public class EventDataSerializer : JsonConverter
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x16D7030", Offset = "0x16D7030", VA = "0x16D7030")]
		public EventDataSerializer()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x16D7038", Offset = "0x16D7038", VA = "0x16D7038", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x16D71C4", Offset = "0x16D71C4", VA = "0x16D71C4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x16D722C", Offset = "0x16D722C", VA = "0x16D722C", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
