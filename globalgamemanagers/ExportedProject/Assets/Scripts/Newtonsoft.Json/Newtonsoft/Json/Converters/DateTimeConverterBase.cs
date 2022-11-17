using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F8")]
	[Preserve]
	public abstract class DateTimeConverterBase : JsonConverter
	{
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xD3BB28", Offset = "0xD3BB28", VA = "0xD3BB28", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xD3BC60", Offset = "0xD3BC60", VA = "0xD3BC60")]
		protected DateTimeConverterBase()
		{
		}
	}
}
