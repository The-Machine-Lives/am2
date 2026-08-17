using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace fastJSON
{
	[Token(Token = "0x2000002")]
	public sealed class JSONParameters
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		public bool UseOptimizedDatasetSchema;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x11")]
		public bool UseFastGuid;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x12")]
		public bool SerializeNullValues;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x13")]
		public bool UseUTCDateTime;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x14")]
		public bool UsingGlobalTypes;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x15")]
		public bool UseExtensions;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x16")]
		public bool UseEscapedUnicode;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		public List<Type> IgnoreAttributes;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		public byte SerializerMaxDepth;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x181339C", Offset = "0x181339C", VA = "0x181339C")]
		public JSONParameters()
		{
		}
	}
}
