using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x200002E")]
	[Preserve]
	public class JsonReaderException : JsonException
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F698", Offset = "0x80F698")]
		private int _003CLineNumber_003Ek__BackingField;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F6A8", Offset = "0x80F6A8")]
		private int _003CLinePosition_003Ek__BackingField;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F6B8", Offset = "0x80F6B8")]
		private string _003CPath_003Ek__BackingField;

		[Token(Token = "0x17000027")]
		private int LineNumber
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xD51B34", Offset = "0xD51B34", VA = "0xD51B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810018", Offset = "0x810018")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		private int LinePosition
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xD51B3C", Offset = "0xD51B3C", VA = "0xD51B3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810028", Offset = "0x810028")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		private string Path
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xD51B44", Offset = "0xD51B44", VA = "0xD51B44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810038", Offset = "0x810038")]
			set
			{
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xD51B4C", Offset = "0xD51B4C", VA = "0xD51B4C")]
		public JsonReaderException()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xD51B50", Offset = "0xD51B50", VA = "0xD51B50")]
		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xD51B54", Offset = "0xD51B54", VA = "0xD51B54")]
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD38468", Offset = "0xD38468", VA = "0xD38468")]
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD51B90", Offset = "0xD51B90", VA = "0xD51B90")]
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xD51C20", Offset = "0xD51C20", VA = "0xD51C20")]
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
