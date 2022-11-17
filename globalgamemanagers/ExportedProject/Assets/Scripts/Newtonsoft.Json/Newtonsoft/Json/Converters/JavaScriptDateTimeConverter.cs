using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000101")]
	[Preserve]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x600080D")]
		[Address(RVA = "0xD3C79C", Offset = "0xD3C79C", VA = "0xD3C79C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xD3C974", Offset = "0xD3C974", VA = "0xD3C974", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xD3CDF8", Offset = "0xD3CDF8", VA = "0xD3CDF8")]
		public JavaScriptDateTimeConverter()
		{
		}
	}
}
