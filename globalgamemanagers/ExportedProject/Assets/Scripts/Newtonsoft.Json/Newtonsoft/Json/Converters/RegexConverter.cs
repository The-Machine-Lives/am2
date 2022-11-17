using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FC")]
	[Preserve]
	public class RegexConverter : JsonConverter
	{
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xD3DA84", Offset = "0xD3DA84", VA = "0xD3DA84", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xD3DF04", Offset = "0xD3DF04", VA = "0xD3DF04")]
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xD3DBBC", Offset = "0xD3DBBC", VA = "0xD3DBBC")]
		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xD3DD40", Offset = "0xD3DD40", VA = "0xD3DD40")]
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xD3DF24", Offset = "0xD3DF24", VA = "0xD3DF24", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xD3E298", Offset = "0xD3E298", VA = "0xD3E298")]
		private object ReadRegexString(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD3DFF4", Offset = "0xD3DFF4", VA = "0xD3DFF4")]
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xD3E4B0", Offset = "0xD3E4B0", VA = "0xD3E4B0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xD3E530", Offset = "0xD3E530", VA = "0xD3E530")]
		public RegexConverter()
		{
		}
	}
}
