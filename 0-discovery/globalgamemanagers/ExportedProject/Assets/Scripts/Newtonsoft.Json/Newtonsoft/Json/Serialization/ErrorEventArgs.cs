using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000085")]
	[Preserve]
	public class ErrorEventArgs : EventArgs
	{
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F808", Offset = "0x80F808")]
		private object _003CCurrentObject_003Ek__BackingField;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F818", Offset = "0x80F818")]
		private ErrorContext _003CErrorContext_003Ek__BackingField;

		[Token(Token = "0x17000093")]
		private object CurrentObject
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xD116A8", Offset = "0xD116A8", VA = "0xD116A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810598", Offset = "0x810598")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		private ErrorContext ErrorContext
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xD116B0", Offset = "0xD116B0", VA = "0xD116B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8105A8", Offset = "0x8105A8")]
			set
			{
			}
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xD116B8", Offset = "0xD116B8", VA = "0xD116B8")]
		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
		}
	}
}
