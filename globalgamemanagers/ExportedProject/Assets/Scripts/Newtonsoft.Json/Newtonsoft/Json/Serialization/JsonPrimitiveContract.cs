using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000084")]
	[Preserve]
	public class JsonPrimitiveContract : JsonContract
	{
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F7F8", Offset = "0x80F7F8")]
		private PrimitiveTypeCode _003CTypeCode_003Ek__BackingField;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;

		[Token(Token = "0x17000092")]
		internal PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xD151F4", Offset = "0xD151F4", VA = "0xD151F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810578", Offset = "0x810578")]
			get
			{
				return default(PrimitiveTypeCode);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xD151FC", Offset = "0xD151FC", VA = "0xD151FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810588", Offset = "0x810588")]
			set
			{
			}
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xD0DD70", Offset = "0xD0DD70", VA = "0xD0DD70")]
		public JsonPrimitiveContract(Type underlyingType)
		{
		}
	}
}
