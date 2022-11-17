using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000095")]
	[Preserve]
	public class ErrorContext
	{
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F868", Offset = "0x80F868")]
		private bool _003CTraced_003Ek__BackingField;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F878", Offset = "0x80F878")]
		private Exception _003CError_003Ek__BackingField;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F888", Offset = "0x80F888")]
		private object _003COriginalObject_003Ek__BackingField;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F898", Offset = "0x80F898")]
		private object _003CMember_003Ek__BackingField;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F8A8", Offset = "0x80F8A8")]
		private string _003CPath_003Ek__BackingField;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F8B8", Offset = "0x80F8B8")]
		private bool _003CHandled_003Ek__BackingField;

		[Token(Token = "0x1700009C")]
		internal bool Traced
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xD11684", Offset = "0xD11684", VA = "0xD11684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8106A0", Offset = "0x8106A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xD1168C", Offset = "0xD1168C", VA = "0xD1168C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8106B0", Offset = "0x8106B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Exception Error
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xD11698", Offset = "0xD11698", VA = "0xD11698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8106C0", Offset = "0x8106C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xD11674", Offset = "0xD11674", VA = "0xD11674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8106D0", Offset = "0x8106D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		private object OriginalObject
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xD11664", Offset = "0xD11664", VA = "0xD11664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8106E0", Offset = "0x8106E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		private object Member
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xD1166C", Offset = "0xD1166C", VA = "0xD1166C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8106F0", Offset = "0x8106F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		private string Path
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xD1167C", Offset = "0xD1167C", VA = "0xD1167C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810700", Offset = "0x810700")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool Handled
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xD116A0", Offset = "0xD116A0", VA = "0xD116A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810710", Offset = "0x810710")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD11618", Offset = "0xD11618", VA = "0xD11618")]
		internal ErrorContext(object originalObject, object member, string path, Exception error)
		{
		}
	}
}
