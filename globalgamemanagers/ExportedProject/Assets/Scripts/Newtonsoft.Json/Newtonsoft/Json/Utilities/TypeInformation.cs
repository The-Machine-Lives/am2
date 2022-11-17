using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000058")]
	[Preserve]
	internal class TypeInformation
	{
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F768", Offset = "0x80F768")]
		private Type _003CType_003Ek__BackingField;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F778", Offset = "0x80F778")]
		private PrimitiveTypeCode _003CTypeCode_003Ek__BackingField;

		[Token(Token = "0x17000064")]
		public Type Type
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x1774038", Offset = "0x1774038", VA = "0x1774038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810278", Offset = "0x810278")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x1774040", Offset = "0x1774040", VA = "0x1774040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810288", Offset = "0x810288")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x1774048", Offset = "0x1774048", VA = "0x1774048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810298", Offset = "0x810298")]
			get
			{
				return default(PrimitiveTypeCode);
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1774050", Offset = "0x1774050", VA = "0x1774050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8102A8", Offset = "0x8102A8")]
			set
			{
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1774058", Offset = "0x1774058", VA = "0x1774058")]
		public TypeInformation()
		{
		}
	}
}
