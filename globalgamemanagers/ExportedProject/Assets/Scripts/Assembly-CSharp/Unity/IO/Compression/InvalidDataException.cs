using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Serializable]
	[Token(Token = "0x20005F9")]
	public sealed class InvalidDataException : SystemException
	{
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0xAB28B4", Offset = "0xAB28B4", VA = "0xAB28B4")]
		public InvalidDataException()
		{
		}

		[Token(Token = "0x6002C31")]
		[Address(RVA = "0xAAF0BC", Offset = "0xAAF0BC", VA = "0xAAF0BC")]
		public InvalidDataException(string message)
		{
		}

		[Token(Token = "0x6002C32")]
		[Address(RVA = "0xAB2BA0", Offset = "0xAB2BA0", VA = "0xAB2BA0")]
		public InvalidDataException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6002C33")]
		[Address(RVA = "0xAB2BA8", Offset = "0xAB2BA8", VA = "0xAB2BA8")]
		internal InvalidDataException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
