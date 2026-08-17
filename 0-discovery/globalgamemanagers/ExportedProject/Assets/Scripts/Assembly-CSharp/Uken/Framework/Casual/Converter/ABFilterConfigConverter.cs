using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Uken.Library.Jingot;

namespace Uken.Framework.Casual.Converter
{
	[Token(Token = "0x2000595")]
	public class ABFilterConfigConverter : JsonConverter
	{
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0xA5AD58", Offset = "0xA5AD58", VA = "0xA5AD58", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0xA5ADDC", Offset = "0xA5ADDC", VA = "0xA5ADDC")]
		protected bool IsDateTimeFilterFunction(ABFilterFunctions filterFunction)
		{
			return default(bool);
		}

		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0xA5ADF4", Offset = "0xA5ADF4", VA = "0xA5ADF4")]
		protected string GetFormattedDateTimeCurryValue(string curry)
		{
			return null;
		}

		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0xA5AED4", Offset = "0xA5AED4", VA = "0xA5AED4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0xA5B1B0", Offset = "0xA5B1B0", VA = "0xA5B1B0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0xA5B544", Offset = "0xA5B544", VA = "0xA5B544")]
		public ABFilterConfigConverter()
		{
		}
	}
}
