using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x200002D")]
	[Preserve]
	public class JsonWriterException : JsonException
	{
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F688", Offset = "0x80F688")]
		private string _003CPath_003Ek__BackingField;

		[Token(Token = "0x17000026")]
		private string Path
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xFEA208", Offset = "0xFEA208", VA = "0xFEA208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810008", Offset = "0x810008")]
			set
			{
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xFEA210", Offset = "0xFEA210", VA = "0xFEA210")]
		public JsonWriterException()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xFEA218", Offset = "0xFEA218", VA = "0xFEA218")]
		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xFEA220", Offset = "0xFEA220", VA = "0xFEA220")]
		internal JsonWriterException(string message, Exception innerException, string path)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xFE38F8", Offset = "0xFE38F8", VA = "0xFE38F8")]
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xFEA24C", Offset = "0xFEA24C", VA = "0xFEA24C")]
		internal static JsonWriterException Create(string path, string message, Exception ex)
		{
			return null;
		}
	}
}
