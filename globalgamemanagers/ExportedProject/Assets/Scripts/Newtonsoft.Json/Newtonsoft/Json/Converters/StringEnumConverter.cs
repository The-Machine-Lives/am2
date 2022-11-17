using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FD")]
	[Preserve]
	public class StringEnumConverter : JsonConverter
	{
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FCC8", Offset = "0x80FCC8")]
		private bool _003CCamelCaseText_003Ek__BackingField;

		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FCD8", Offset = "0x80FCD8")]
		private bool _003CAllowIntegerValues_003Ek__BackingField;

		[Token(Token = "0x1700016E")]
		public bool CamelCaseText
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0xD3E538", Offset = "0xD3E538", VA = "0xD3E538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8116A4", Offset = "0x8116A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016F")]
		public bool AllowIntegerValues
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0xD3E540", Offset = "0xD3E540", VA = "0xD3E540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8116B4", Offset = "0x8116B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0xD3E548", Offset = "0xD3E548", VA = "0xD3E548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8116C4", Offset = "0x8116C4")]
			set
			{
			}
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xD3E554", Offset = "0xD3E554", VA = "0xD3E554")]
		public StringEnumConverter()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xD3E580", Offset = "0xD3E580", VA = "0xD3E580", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xD3E7E8", Offset = "0xD3E7E8", VA = "0xD3E7E8", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD3ED08", Offset = "0xD3ED08", VA = "0xD3ED08", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
