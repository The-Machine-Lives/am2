using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F7")]
	[Preserve]
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		[Token(Token = "0x1700016C")]
		public override bool CanWrite
		{
			[Token(Token = "0x60007D3")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007CF")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007D0")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		public abstract T Create(Type objectType);

		[Token(Token = "0x60007D2")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D4")]
		protected CustomCreationConverter()
		{
		}
	}
}
