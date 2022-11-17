using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x2000015")]
	[Preserve]
	public class JsonException : Exception
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xD4D4DC", Offset = "0xD4D4DC", VA = "0xD4D4DC")]
		public JsonException()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xD4D544", Offset = "0xD4D544", VA = "0xD4D544")]
		public JsonException(string message)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xD4D5BC", Offset = "0xD4D5BC", VA = "0xD4D5BC")]
		public JsonException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xD4D63C", Offset = "0xD4D63C", VA = "0xD4D63C")]
		public JsonException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
