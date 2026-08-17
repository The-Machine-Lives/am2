using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x2000034")]
	[Preserve]
	public class JsonSerializationException : JsonException
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD51E30", Offset = "0xD51E30", VA = "0xD51E30")]
		public JsonSerializationException()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xD3B12C", Offset = "0xD3B12C", VA = "0xD3B12C")]
		public JsonSerializationException(string message)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xD51E34", Offset = "0xD51E34", VA = "0xD51E34")]
		public JsonSerializationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD51E38", Offset = "0xD51E38", VA = "0xD51E38")]
		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD3B4C4", Offset = "0xD3B4C4", VA = "0xD3B4C4")]
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD3EC78", Offset = "0xD3EC78", VA = "0xD3EC78")]
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD51E3C", Offset = "0xD51E3C", VA = "0xD51E3C")]
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
