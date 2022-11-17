using System;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000100")]
	[Preserve]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x10")]
		private DateTimeStyles _dateTimeStyles;

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x18")]
		private string _dateTimeFormat;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x20")]
		private CultureInfo _culture;

		[Token(Token = "0x17000173")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0xD3BFB8", Offset = "0xD3BFB8", VA = "0xD3BFB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xD3C030", Offset = "0xD3C030", VA = "0xD3C030", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xD3C274", Offset = "0xD3C274", VA = "0xD3C274", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xD3C78C", Offset = "0xD3C78C", VA = "0xD3C78C")]
		public IsoDateTimeConverter()
		{
		}
	}
}
