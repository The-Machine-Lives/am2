using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000033")]
	[Preserve]
	public static class JsonConvert
	{
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F6E8", Offset = "0x80F6E8")]
		private static Func<JsonSerializerSettings> _003CDefaultSettings_003Ek__BackingField;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string True;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string False;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string Null;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string Undefined;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string PositiveInfinity;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string NegativeInfinity;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string NaN;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x40")]
		private static readonly JsonSerializerSettings InitialSerializerSettings;

		[Token(Token = "0x1700003A")]
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xD4BFF0", Offset = "0xD4BFF0", VA = "0xD4BFF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810088", Offset = "0x810088")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xD4C058", Offset = "0xD4C058", VA = "0xD4C058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810098", Offset = "0x810098")]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD4C0C4", Offset = "0xD4C0C4", VA = "0xD4C0C4")]
		static JsonConvert()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD4C1F8", Offset = "0xD4C1F8", VA = "0xD4C1F8")]
		internal static JsonSerializerSettings GetDefaultSettings()
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD4C260", Offset = "0xD4C260", VA = "0xD4C260")]
		public static string ToString(bool value)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD4C2F4", Offset = "0xD4C2F4", VA = "0xD4C2F4")]
		public static string ToString(char value)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD4C3F4", Offset = "0xD4C3F4", VA = "0xD4C3F4")]
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD4C61C", Offset = "0xD4C61C", VA = "0xD4C61C")]
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD4C760", Offset = "0xD4C760", VA = "0xD4C760")]
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD4C4E4", Offset = "0xD4C4E4", VA = "0xD4C4E4")]
		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD4C84C", Offset = "0xD4C84C", VA = "0xD4C84C")]
		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD4C8D4", Offset = "0xD4C8D4", VA = "0xD4C8D4")]
		public static string ToString(decimal value)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD4C38C", Offset = "0xD4C38C", VA = "0xD4C38C")]
		public static string ToString(string value)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD4C988", Offset = "0xD4C988", VA = "0xD4C988")]
		public static string ToString(string value, char delimiter)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xD4CA00", Offset = "0xD4CA00", VA = "0xD4CA00")]
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD4CAE8", Offset = "0xD4CAE8", VA = "0xD4CAE8")]
		public static string SerializeObject(object value)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD4CBE0", Offset = "0xD4CBE0", VA = "0xD4CBE0")]
		public static string SerializeObject(object value, Formatting formatting)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD4CCD8", Offset = "0xD4CCD8", VA = "0xD4CCD8")]
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD4CB54", Offset = "0xD4CB54", VA = "0xD4CB54")]
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD4CC58", Offset = "0xD4CC58", VA = "0xD4CC58")]
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD4CFA8", Offset = "0xD4CFA8", VA = "0xD4CFA8")]
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD4CD88", Offset = "0xD4CD88", VA = "0xD4CD88")]
		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD4D05C", Offset = "0xD4D05C", VA = "0xD4D05C")]
		public static object DeserializeObject(string value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		public static T DeserializeObject<T>(string value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000129")]
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			return (T)null;
		}

		[Token(Token = "0x600012A")]
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			return (T)null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD4D2A8", Offset = "0xD4D2A8", VA = "0xD4D2A8")]
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD4D0D4", Offset = "0xD4D0D4", VA = "0xD4D0D4")]
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}
	}
}
